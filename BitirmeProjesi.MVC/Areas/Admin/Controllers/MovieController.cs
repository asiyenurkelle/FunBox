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

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICommentService _commentService;
        public MovieController(IMovieService movieService, ICommentService commentService)
        {
            _movieService = movieService;
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


        //[HttpGet]
        //public IActionResult AddComment(int id)
        //{
        //    CommentAddDto model = new CommentAddDto();
        //    model.Movie.Id = id;
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddComment(CommentAddDto commentAddDto)
        //{
        //    if (ModelState.IsValid)
        //    {
              
        //        var result = await _commentService.Add(commentAddDto);
        //        if (result.ResultStatus == ResultStatus.Success)
        //        {
        //            return View(result);
        //        }

        //    }
        //    return View("Details");
        //}


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


    }
}
