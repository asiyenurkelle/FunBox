using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MoodTestController : Controller
    {
        private readonly IAnswerService _answerService;
        public MoodTestController(IAnswerService answerService)
        {
            _answerService = answerService;
        }
        public async Task <IActionResult> Index()
        {
            TempData["Active"] = "ModTesti";
            var result = await _answerService.GetAll();
            return View(result.Data);
        }
    }
}
