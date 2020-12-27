﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;

namespace BitirmeProjesi.MVC.Areas.Anasayfa.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IBookSerieMovieService _bookSerieMovieService;
        public HomeController(IBookSerieMovieService bookSerieMovieService)
        {
            _bookSerieMovieService = bookSerieMovieService;
        }
        public async Task<IActionResult> Index(int? id)
        {
            TempData["Active"] = "Anasayfa";
            ViewBag.SelectedCategory = RouteData.Values["id"];
            if (id == null)
            {
                var result = await _bookSerieMovieService.GetAll();
                return View(result.Data);
            }
            else
            {
                var result = await _bookSerieMovieService.GetCategories((int)id);
                return View(result.Data);
            }
           
        }
        public async Task<IActionResult> Search(string searchString)
        {
            if (!string.IsNullOrWhiteSpace(searchString))
            {
                ViewBag.SearchString = searchString;
                var result = await _bookSerieMovieService.Search(searchString);
                return View(result.Data);
            }
            else
            {
                return BadRequest();
            }
        }
            
      


    }
}
