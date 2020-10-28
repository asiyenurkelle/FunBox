using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Concrete
{
    public class Comment:EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public int CategoryId { get; set; }
       
        public Category Category { get; set; }
        public Movie Movie { get; set; }
        public Serie Serie { get; set; }
        public Book Book { get; set; }

        public int MovieId { get; set; }
        public int SerieId { get; set; }
        public int BookId { get; set; }

        
    }
}
