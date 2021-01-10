using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        private readonly ISerieCommentService _serieCommentService;

        private readonly IMapper _mapper;

        public SerieController(ISerieService serieService, ISerieQuestionService serieQuestionService, ISerieCommentService serieCommentService, IMapper mapper)
        {
            _serieService = serieService;
            _serieQuestionService = serieQuestionService;
            _serieCommentService = serieCommentService;
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


     

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> MoodTesting()
        {
            TempData["Active"] = "ÖneriTesti";
            var result = await _serieQuestionService.GetQuestions();
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
                    var commentAddDto = _mapper.Map<CommentAddSerieDto>(commentAddViewModel);
                    var result = await _serieCommentService.AddComment(commentAddDto);
                    if (result.ResultStatus == ResultStatus.Success)
                    {

                        return RedirectToAction("Details", new { Id = commentAddDto.SerieId });
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

        public async Task<IActionResult> GetSerieLessThanOneHour()
        {
            var result = await _serieService.GetSerieLessThanOneHour();
            var series = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(series);

        }

        public async Task<IActionResult> GetSerieMoreThanOneHour()
        {
            var result = await _serieService.GetSerieMoreThanOneHour();
            var series = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(series);

        }

        public async Task<IActionResult> GetImdbGreaterThanSeven()
        {
            var result = await _serieService.GetImdbGreaterThanSeven();
            var series = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(series);

        }
        public async Task<IActionResult> GetImdbAll()
        {
            var result = await _serieService.GetImdbAll();
            var series = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(series);

        }
        public async Task<IActionResult> GetSerieLessThanFiveSeason()
        {
            var result = await _serieService.GetSerieLessThanFiveSeason();
            var series = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(series);

        }

        public async Task<IActionResult> GetSerieMoreThanFiveSeason()
        {
            var result = await _serieService.GetSerieMoreThanFiveSeason();
            var series = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(series);

        }
        [HttpPost]
        public async Task<JsonResult> Delete(int commentId)
        {
            var result = await _serieCommentService.CommentDelete(commentId);
            var ajaxResult = JsonSerializer.Serialize(result);
            return Json(ajaxResult);
        }

        [HttpGet]
        public async Task<IActionResult> CommentUpdatePartial(int id)
        {
            ViewBag.deger = id;
            var result = await _serieCommentService.GetCommentUpdateDto(id);
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
            var result = await _serieCommentService.UpdateComment(commentUpdateDto);
            var comments = await _serieCommentService.GetAllComment();
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

