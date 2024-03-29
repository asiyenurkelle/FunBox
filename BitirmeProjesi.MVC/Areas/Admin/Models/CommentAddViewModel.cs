﻿using BitirmeProjesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeProjesi.MVC.Areas.Admin.Models
{
    public class CommentAddViewModel
    {
        [DisplayName("Yorum Başlığı:")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır!")]
        //[MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır!")]
        public string Title { get; set; }

        [DisplayName("Yorum İçeriği:")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir!")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır!")]
        //[MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır!")]
        public string Subject { get; set; }
        public int MovieId { get; set; }
        public int SerieId { get; set; }
        public int BookId { get; set; }
        public string AuthorName { get; set; }

        public int Id { get; set; } //commentınıd si
    }
}
