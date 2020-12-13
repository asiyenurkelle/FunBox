using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SerieController : Controller
    {
        private readonly ISerieService _serieService;
        private readonly ISerieQuestionService _serieQuestionService;

        public SerieController(ISerieService serieService, ISerieQuestionService serieQuestionService)
        {
            _serieService = serieService;
            _serieQuestionService = serieQuestionService;
        }

        public async Task<IActionResult> Index(int? id)
        {
            TempData["Active"] = "Dizi";
            ViewBag.SelectedCategory = RouteData.Values["id"];
            if (id == null)
            {
                var result = await _serieService.GetAll();
                return View(result.Data);
            }
            else
            {
                var result = await _serieService.GetCategories((int)id);
                return View(result.Data);
            }
        }

        [HttpGet("Admin/Serie/Details/{Id}")]
        public async Task<IActionResult> Details(int Id)
        {
            TempData["Active"] = "Dizi";
            var result = await _serieService.Get(Id);
            return View(result.Data);
        }


        [HttpGet("Serie/Details/AddList")]
        public async Task<IActionResult> AddList(int Id)
        {
            TempData["Active"] = "Dizi";
            await _serieService.AddListSerie(Id);
            return Json(null);
        }

        [HttpGet]
        public async Task<IActionResult> MoodTesting()
        {
            TempData["Active"] = "ModTesti";
            var result = await _serieQuestionService.GetQuestions();
            return View(result.Data);
        }
    }
}
