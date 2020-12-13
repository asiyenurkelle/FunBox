using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using System.Text.Json;
using BitirmeProjesi.MVC.Areas.Admin.Models;
using BitirmeProjesi.Shared.Utilities.Extensions;
using BitirmeProjesi.Entities.Concrete;
using System.Text.Json.Serialization;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICommentService _commentService;
        private readonly IMovieQuestionService _movieQuestionService;
        public MovieController(IMovieService movieService, IMovieQuestionService movieQuestionService, ICommentService commentService)
        {
            _movieService = movieService;
            _movieQuestionService = movieQuestionService;
            _commentService = commentService;
        }
        public async Task<IActionResult> Index(int? id)
        {
            TempData["Active"] = "Film";
            ViewBag.SelectedCategory = RouteData.Values["id"];
            if (id == null)
            {
                var result = await _movieService.GetAll();
                return View(result.Data);
            }
            else
            {
                var result = await _movieService.GetCategories((int)id);
                return View(result.Data);
            }
        }

        [HttpGet("Admin/Movie/Details/{Id}")]
        public async Task<IActionResult> Details(int Id)
        {
            TempData["Active"] = "Film";
            var result = await _movieService.Get(Id);
            return View(result.Data);
        }

        [HttpGet("Movie/Details/AddList")]
        public async Task<IActionResult> AddList(int Id)
        {
            TempData["Active"] = "Film";
            await _movieService.AddListMovie(Id);
            return Json(null);
        }

        [HttpGet]
        public async Task<IActionResult> MoodTesting()
        {
            TempData["Active"] = "ModTesti";
            var result = await _movieQuestionService.GetQuestions();
            return View(result.Data);
        }

        [HttpGet]
        public IActionResult AddComment(int id)
        {
            //CommentAddDto model = new CommentAddDto();
            //model.CommentId = id;
            return View(new CommentAddDto());
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentAddDto commentAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _commentService.Add(commentAddDto);

                if (result.ResultStatus == ResultStatus.Success)
                {
                    return View(result.Data);
                }
            }
           

            return RedirectToAction("Index", "Movie");
        }


        //[HttpPost]
        //public async Task<IActionResult> AddComment(CommentAddDto commentAddDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _commentService.Add(commentAddDto);
        //        if (result.ResultStatus == ResultStatus.Success)
        //        {
        //           var commentAddAjaxModel=JsonSerializer.Serialize(new CommentAddAjaxViewModel
        //            return View(result.Data);
        //        }

        //    }
        //    return View("Details");
        //}
        public async Task<IActionResult> GetSuggestionsLessTwo()
        {
            var result = await _movieService.GetAllLessThanTwoHour();
            var movies = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(movies);

        }
        public async Task<IActionResult> GetSuggestionsMoreTwo()
        {
            var result = await _movieService.GetAllMoreThanTwoHour();
            var movies = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(movies);

        }

    }
}
