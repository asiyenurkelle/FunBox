using BitirmeProjesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Dtos
{
    public class CommentUpdateDto
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public Movie Movie { get; set; }
        public string Name { get; set; }
        public Serie Serie { get; set; }
        public Book Book { get; set; }
        
    }
}
