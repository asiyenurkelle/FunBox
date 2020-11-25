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

        public ActivitiesController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public async Task< IActionResult> Index()
        {
            var result = await _activityService.GetActivities();
            return View(result.Data);
        }
    }
}
