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
using System.Text.Json;
using System.Text.Json.Serialization;
using BitirmeProjesi.MVC.Areas.Admin.Models;
using AutoMapper;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]

    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IBookQuestionService _bookQuestionService;
        private readonly IBookCommentService _bookCommentService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IBookQuestionService bookQuestionService, IBookCommentService bookCommentService, IMapper mapper)
        {
            _bookService = bookService;
            _bookQuestionService = bookQuestionService;
            _bookCommentService = bookCommentService;
            _mapper = mapper;


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
            TempData["Active"] = "ÖneriTesti";
            var result = await _bookQuestionService.GetQuestions();
            return View(result.Data);
        }
        [HttpGet]
        [Authorize]
        public IActionResult AddComment(int id)
        {
            ViewBag.deger = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentAddViewModel commentAddViewModel)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    var commentAddDto = _mapper.Map<CommentAddBookDto>(commentAddViewModel);
                    var result = await _bookService.AddComment(commentAddDto);
                    if (result.ResultStatus == ResultStatus.Success)
                    {

                        return RedirectToAction("Details", new { Id = commentAddDto.BookId });
                    }
                }
                catch (Exception exc)
                {
                    return RedirectToAction("PleaseEditComment");
                }

            }
            return View(commentAddViewModel);
        }
        public IActionResult PleaseEditComment()
        {
            return View();
        }
        public async Task<IActionResult> GetBookLessThanTwoHundredPage()
        {
            var result = await _bookService.GetBookLessThanTwoHundredPage();
            var books = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(books);
        }

        public async Task<IActionResult> GetBookMoreThanTwoHundredPage()
        {
            var result = await _bookService.GetBookMoreThanTwoHundredPage();
            var books = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(books);

        }
        public async Task<IActionResult> GetBookClassical()
        {
            var result = await _bookService.GetBookClassical();
            var books = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(books);

        }
        public async Task<IActionResult> GetBookNonClassical()
        {
            var result = await _bookService.GetBookNonClassical();
            var books = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(books);

        }
        public async Task<IActionResult> GetBookDateLess1990()
        {
            var result = await _bookService.GetBookDateLess1990();
            var books = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(books);

        }
        public async Task<IActionResult> GetBookDateThan1990()
        {
            var result = await _bookService.GetBookDateThan1990();
            var books = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(books);

        }

        [HttpPost]
        public async Task<JsonResult> Delete(int commentId)
        {
            var result = await _bookCommentService.CommentDelete(commentId);
            var ajaxResult = JsonSerializer.Serialize(result);
            return Json(ajaxResult);
        }

        [HttpGet]
        public async Task<IActionResult> CommentUpdatePartial(int id)
        {
            ViewBag.deger = id;
            var result = await _bookCommentService.GetCommentUpdateDto(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpPost]
        public async Task<IActionResult> CommentUpdatePartial(CommentUpdateViewModel commentUpdateViewModel)
        {
            var commentUpdateDto = _mapper.Map<CommentUpdateDto>(commentUpdateViewModel);
            var result = await _bookCommentService.UpdateComment(commentUpdateDto);
            var comments = await _bookCommentService.GetAll();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", result.Message);
                return View(commentUpdateViewModel);
            }

        }

    }
}
