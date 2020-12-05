using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Dtos
{
    public class MoodTestingDto : DtoGetBase
    {
        public IList<Answer> Answers { get; set; }
        public IList<Question> Questions { get; set; }
        public IList<Book> Books { get; set; }
        public IList<Serie> Series { get; set; }
        public IList<Movie> Movies { get; set; }


    }
}
