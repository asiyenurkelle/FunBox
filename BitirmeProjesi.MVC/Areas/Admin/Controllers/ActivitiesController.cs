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

        public async Task<IActionResult> RemoveActivity(int Id)
        {
            var movie = await _activityService.DeleteActivitiesMovie(Id);
            var serie = await _activityService.DeleteActivitiesSerie(Id);
            var book = await _activityService.DeleteActivitiesBook(Id);
            return Json(null);

        }
        //public async Task<IActionResult> RemoveActivityBook(int Id)
        //{
        //    var serie = await _activityService.DeleteActivitiesBook(Id);
        //    return Json(null);

        //}
        //public async Task<IActionResult> RemoveActivitySerie(int Id)
        //{
        //    var serie = await _activityService.DeleteActivitiesSerie(Id);
        //    return Json(null);

        //}
        //public async Task<IActionResult> RemoveActivityMovie(int Id)
        //{
        //    var serie = await _activityService.DeleteActivitiesMovie(Id);
        //    return Json(null);

        //}
    }
}
