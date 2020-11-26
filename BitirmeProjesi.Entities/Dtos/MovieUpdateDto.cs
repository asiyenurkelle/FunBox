using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Dtos
{
    public class MovieUpdateDto:DtoGetBase
    {
        [Required]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Subject { get; set; }
        public bool Activities { get; set; } = false;
        public string ThumbNail { get; set; }
        public string Time { get; set; }
        public string Scenarist { get; set; }
        public string Production { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
    }
}
