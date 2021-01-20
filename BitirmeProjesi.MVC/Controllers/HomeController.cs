using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitirmeProjesi.Services.Abstract;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;

namespace BitirmeProjesi.MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBookSerieMovieService _bookSerieMovieService;
        private readonly IBookService _bookService;
        public HomeController(IBookSerieMovieService bookSerieMovieService, IBookService bookService)
        {
            _bookSerieMovieService = bookSerieMovieService;
            _bookService = bookService;
        }

        public async Task<IActionResult> Index(int? id, int currentPage=1,int pageSize=3)
        {
            TempData["Active"] = "Anasayfa";
            ViewBag.SelectedCategory = RouteData.Values["id"];
            if (id == null)
            {
                var result = await _bookSerieMovieService.GetAllByPagingAsync(null,currentPage,pageSize);

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
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return View(result.Data);
                }
                else
                {
                    
                    return RedirectToAction("SearchNotFound");
                }
               
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult SearchNotFound()
        {
            return View();
        }
       
        public async Task<IActionResult> ImdbDatatable()
        {
            TempData["Active"] = "Gözat";
            var result = await _bookSerieMovieService.GetOrderByImdb();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            else
            {
                return RedirectToAction("Index");

            }
        }
        public async Task<IActionResult> DiscoverBookDataTable()
        {
            TempData["Active"] = "Gözat";
            var result = await _bookService.GetAll();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            else
            {
                return RedirectToAction("Index");

            }
        }


    }

}
