using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BitirmeProjesi.Entities.Dtos;
using BitirmeProjesi.MVC.Areas.Admin.Models;
using BitirmeProjesi.Services.Abstract;
using BitirmeProjesi.Shared.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;

namespace BitirmeProjesi.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_CommentAddPartial");
        }
        [HttpPost]
        public async Task<IActionResult> Add(CommentAddDto commentAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _commentService.Add(commentAddDto);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var commentAddAjaxModel = JsonSerializer.Serialize(new CommentAddAjaxViewModel
                    {
                        CommentDto = result.Data,
                        CommentAddPartial = await this.RenderViewToStringAsync("_CommentAddPartial", commentAddDto)
                    });
                    return Json(commentAddAjaxModel);
                }
            }
            var commentAddAjaxErrorModel = JsonSerializer.Serialize(new CommentAddAjaxViewModel
            {
                CommentAddPartial = await this.RenderViewToStringAsync("_CommentAddPartial", commentAddDto)
            });
            return Json(commentAddAjaxErrorModel);

        }
    }
}
