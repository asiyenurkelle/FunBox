using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using Microsoft.AspNetCore.Identity;
using BitirmeProjesi.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]

    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IBookQuestionService _bookQuestionService;

        public BookController(IBookService bookService, IBookQuestionService bookQuestionService)
        {
            _bookService = bookService;
            _bookQuestionService = bookQuestionService;
           
           
        }
        public async Task<IActionResult> Index(int? id)
        {
            TempData["Active"] = "Kitap";
            ViewBag.SelectedCategory = RouteData.Values["id"];
            if (id == null)
            {
                var result = await _bookService.GetAll();
                return View(result.Data);
            }
            else
            {
                var result = await _bookService.GetCategories((int)id);
                return View(result.Data);
            }
        }

        [HttpGet("Admin/Book/Details/{Id}")]
        
        public async Task<IActionResult> Details(int Id)
        {
            TempData["Active"] = "Kitap";
            var result = await _bookService.Get(Id);
            return View(result.Data);
        }


        [HttpGet("Book/Details/AddList")]
        
        public async Task<IActionResult> AddList(int Id)
        {
            TempData["Active"] = "Kitap";
            var result = await _bookService.AddListBook(Id);
            return Json(null);
        }

        [HttpGet]
     
        public async Task<IActionResult> MoodTesting()
        {
            TempData["Active"] = "ModTesti";
            var result = await _bookQuestionService.GetQuestions();
            return View(result.Data);
        }


    }
}
