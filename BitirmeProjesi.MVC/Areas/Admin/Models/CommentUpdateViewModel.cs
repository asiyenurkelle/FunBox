using BitirmeProjesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeProjesi.MVC.Areas.Admin.Models
{
    public class CommentUpdateViewModel
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
        public int MovieCommentId { get; set; }
        public int SerieCommentId { get; set; }
        public int BookCommentId { get; set; }


        public int Id { get; set; } //commentınıd si
    }
}
