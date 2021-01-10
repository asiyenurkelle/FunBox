using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ActivitiesController : Controller
    {
        private readonly IActivityService _activityService;
        private readonly IMovieService _movieService;
        private readonly ISerieService _serieService;
        private readonly IBookService _bookService;

        public ActivitiesController(IActivityService activityService, IMovieService movieService, ISerieService serieService, IBookService bookService)
        {
            _activityService = activityService;
            _movieService = movieService;
            _serieService = serieService;
            _bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "Aktiviteler";
            var result = await _activityService.GetActivities();
            return View(result.Data);
        }

        [HttpGet("Book/Details/AddList")]
        [Authorize]
        public async Task<IActionResult> AddList(int Id)
        {
            TempData["Active"] = "Kitap";
            var result = await _bookService.AddListBook(Id);
            return Json(null);
        }

        [HttpGet("Movie/Details/AddList")]
        [Authorize]
        public async Task<IActionResult> AddListMovie(int Id)
        {
            TempData["Active"] = "Film";
            await _movieService.AddListMovie(Id);
            return Json(null);
        }

        [HttpGet("Serie/Details/AddList")]

        public async Task<IActionResult> AddListSerie(int Id)
        {
            TempData["Active"] = "Dizi";
            await _serieService.AddListSerie(Id);
            return Json(null);
        }

        public async Task<IActionResult> RemoveActivityBook(int Id)
        {
            var serie = await _activityService.DeleteActivitiesBook(Id);
            return Json(null);

        }
        public async Task<IActionResult> RemoveActivitySerie(int Id)
        {
            var serie = await _activityService.DeleteActivitiesSerie(Id);
            return Json(null);

        }
        public async Task<IActionResult> RemoveActivityMovie(int Id)
        {
            var serie = await _activityService.DeleteActivitiesMovie(Id);
            return Json(null);

        }
    }
}
