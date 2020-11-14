using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _movieService.GetAll();
            return View(result.Data);
        }
        
        [HttpGet("Admin/Movie/Details/{Id}")]
        public async Task<IActionResult> Details(int Id)
        {
            var result = await _movieService.Get(Id);
            return View(result.Data);
        }
    }
}
