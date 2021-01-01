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
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IMovieQuestionService _movieQuestionService;
        private readonly IMapper _mapper;

        public MovieController(IMovieService movieService, IMovieQuestionService movieQuestionService, ICommentService commentService, IMapper mapper)
        {
            _movieService = movieService;
            _movieQuestionService = movieQuestionService;
            _mapper = mapper;
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
        [Authorize]
        public async Task<IActionResult> AddList(int Id)
        {
            TempData["Active"] = "Film";
            await _movieService.AddListMovie(Id);
            return Json(null);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> MoodTesting()
        {
            TempData["Active"] = "ÖneriTesti";
            var result = await _movieQuestionService.GetQuestions();
            return View(result.Data);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddComment(int Id)
        {
            var movie = _movieService.Get(Id);
            CommentAddDto commentAddDto = new CommentAddDto();
            commentAddDto.MovieId = Id;
            return View(commentAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentAddViewModel commentAddViewModel)
        {
            if (ModelState.IsValid)
            {
                
                var commentAddDto = _mapper.Map<CommentAddDto>(commentAddViewModel);
                var result = await _movieService.AddComment(commentAddDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("Index", "Movie" );
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View(commentAddViewModel);
                }

            }
            return View(commentAddViewModel);
        }


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
        public async Task<IActionResult> GetSuggestionImdbGreaterSeven()
        {
            var result = await _movieService.GetImdbGreaterThanSeven();
            var movies = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(movies);
        }
        public async Task<IActionResult> GetSuggestionImdbAll()
        {
            var result = await _movieService.GetImdbAll();
            var movies = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(movies);
        }
        public async Task<IActionResult> GetDateLess1990()
        {
            var result = await _movieService.GetMovieDateLess1990();
            var movies = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(movies);
        }
        public async Task<IActionResult> GetMovieDateThan1990()
        {
            var result = await _movieService.GetMovieDateThan1990();
            var movies = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(movies);
        }



    }
}
