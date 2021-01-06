using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Concrete
{
    public class SerieComment: EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public int SerieId { get; set; }
        public Serie Serie { get; set; }
        //public bool IsDeleted { get; set; } = false;
       // public string Name { get; set; }
    }
}
