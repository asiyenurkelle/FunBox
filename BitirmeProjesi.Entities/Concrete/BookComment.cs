using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Concrete
{
    public class BookComment : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
