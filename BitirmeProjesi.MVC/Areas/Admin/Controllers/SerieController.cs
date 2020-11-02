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
        public async Task< IActionResult> Index()
        {
            var result = await _serieService.GetAll();
            return View(result.Data);
        }
    }
}
