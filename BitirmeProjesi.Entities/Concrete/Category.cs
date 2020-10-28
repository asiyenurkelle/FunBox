using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Concrete
{
    public class Category:EntityBase,IEntity
    {
       
        public string Name { get; set; }
        
        public ICollection<Movie> Movies { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<Serie> Series { get; set; }


    }
}
