using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using System.Text.Json;

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
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "film";
            var result = await _movieService.GetAll();
            return View(result.Data);
        }
        
        [HttpGet("Admin/Movie/Details/{Id}")]
        public async Task<IActionResult> Details(int Id)
        {
            TempData["Active"] = "film";
            var result = await _movieService.Get(Id);
            return View(result.Data);
        }

        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> AddComment(CommentAddDto commentAddDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _commentService.Add(commentAddDto);
        //        if (result.ResultStatus == ResultStatus.Success)
        //        {
        //            //var sonuc = new CommentAddDto()
        //            //{
        //            //    Subject = commentAddDto.Subject,
        //            //    Title = commentAddDto.Title
        //            //};
        //            return View(result.Data);
        //        }

        //    }
        //    return View("Details"); 
        //}

        [HttpGet("Movie/Details/AddList")]
        public async Task<IActionResult> AddList(int Id)
        {
             await _movieService.AddListMovie(Id);
            return Json(null);
        }
    }
}
