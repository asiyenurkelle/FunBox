using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
     
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
           
        }
        public async Task<IActionResult> Index(int? id)
        {
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
            
            var result = await _bookService.Get(Id);
            return View(result.Data);
        }


        [HttpGet("Book/Details/AddList")]
        public async Task<IActionResult> AddList(int Id)
        {
            var book = await _bookService.AddListBook(Id);
            return Json(null);
        }


    }
}
