﻿using BitirmeProjesi.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeProjesi.MVC.Areas.Admin.Models
{
    public class CommentAddAjaxViewModel
    {
        public CommentAddDto  CommentAddDto { get; set; }
        public string CommentAddPartial  { get; set; }
        public CommentDto commentDto { get; set; }
    }
}
