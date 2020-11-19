using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Dtos
{
    public class UserDetailDto:DtoGetBase
    {
        [DisplayName("Ad Soyad")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public string UserName { get; set; }


        [DisplayName("Telefon numarası")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(11, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(11, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır. ")]
        public string PhoneNumber { get; set; }



        [DisplayName("E-Posta Adresi")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olmamalıdır.")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden küçük olmamalıdır. ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

       
    }
}
