using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
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

        public async Task< IActionResult> Index()
        {
            var result = await _activityService.GetActivities();
            return View(result.Data);
        }

        public async Task<IActionResult> RemoveActivity(int Id)
        {
            var movie = await _movieService.GetMovieUpdateDto(Id);
            var serie = await _serieService.GetSerieUpdateDto(Id);
            var book = await _bookService.GetBookUpdateDto(Id);
            return Json(null);

        }
    }
}
