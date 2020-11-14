﻿using System;
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
        public async Task <IActionResult> Index()
        {
            var result = await _bookService.GetAll();
            return View(result.Data);
        }

       [HttpGet("Admin/Book/Details/{Id}")]
        public async Task<IActionResult> Details(int Id)
        {
            
            var result = await _bookService.Get(Id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
           
         }
    }
}