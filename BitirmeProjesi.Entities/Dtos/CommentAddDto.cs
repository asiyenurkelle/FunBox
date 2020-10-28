using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class CommentAddDto
    {
        [DisplayName("Yorum Başlığı:")]
        [Required(ErrorMessage ="{0} boş geçilmemelidir")]
        [MaxLength(100,ErrorMessage= "{0} {1} karakterden büyük olmamalıdır!")]
        [MinLength(3,ErrorMessage ="{0} {1} karakterden az olmamalıdır!")]
        public string Title { get; set; }

        [DisplayName("Yorum İçeriği:")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir!")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır!")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır!")]
        public string Subject { get; set; }
    }
}
