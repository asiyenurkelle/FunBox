using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Dtos
{
    public class BookUpdateDto
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public string ThumbNail { get; set; }
        public int CategoryId { get; set; }
        public int Page { get; set; }
        public string Writer { get; set; }
        public string Production { get; set; }

        public bool Activities { get; set; } = false;
        public DateTime Date { get; set; }
    }
}
