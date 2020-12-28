using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.MVC.Areas.Admin.Models;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SerieController : Controller
    {
        private readonly ISerieService _serieService;
        private readonly ISerieQuestionService _serieQuestionService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public SerieController(ISerieService serieService, ISerieQuestionService serieQuestionService,ICommentService commentService,IMapper mapper)
        {
            _serieService = serieService;
            _serieQuestionService = serieQuestionService;
            _commentService = commentService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(int? id)
        {
            TempData["Active"] = "Dizi";
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
            TempData["Active"] = "Dizi";
            var result = await _serieService.Get(Id);
            return View(result.Data);
        }


        [HttpGet("Serie/Details/AddList")]
        [Authorize]
        public async Task<IActionResult> AddList(int Id)
        {
            TempData["Active"] = "Dizi";
            await _serieService.AddListSerie(Id);
            return Json(null);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> MoodTesting()
        {
            TempData["Active"] = "ModTesti";
            var result = await _serieQuestionService.GetQuestions();
            return View(result.Data);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddComment()
        {
            return View(new CommentAddDto());
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentAddViewModel commentAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var commentAddDto = _mapper.Map<CommentAddDto>(commentAddViewModel);
                var result = await _serieService.AddComment(commentAddDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("Index", "Serie");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View(commentAddViewModel);
                }

            }
            return View(commentAddViewModel);
        }
    }
}
