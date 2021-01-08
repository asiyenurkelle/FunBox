using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class CommentAddBookDto : DtoGetBase
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
        public int BookId { get; set; }
        public int Id { get; set; } //commentınıd si

        public string AuthorName { get; set; }
    }

}
