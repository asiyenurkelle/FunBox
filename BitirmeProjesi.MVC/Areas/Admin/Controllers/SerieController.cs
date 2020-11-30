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

        public SerieController(ISerieService serieService)
        {
            _serieService = serieService;
        }

        public async Task<IActionResult> Index(int? id)
        {
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

            var result = await _serieService.Get(Id);
            return View(result.Data);
        }




        [HttpGet("Serie/Details/AddList")]
        public async Task<IActionResult> AddList(int Id)
        {
            await _serieService.AddListSerie(Id);
            return Json(null);
        }
    }
}
