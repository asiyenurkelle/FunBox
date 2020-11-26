using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Dtos
{
    public class SerieUpdateDto:DtoGetBase
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public string ThumbNail { get; set; }
        public int CategoryId { get; set; }
        public string Time { get; set; }
        public string Scenarist { get; set; }
        public string Production { get; set; }
      
        public bool Activities { get; set; } = false;
        public DateTime Date { get; set; }
    }
}
