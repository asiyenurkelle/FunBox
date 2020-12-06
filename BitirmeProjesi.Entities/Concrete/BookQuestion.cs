using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Concrete
{
    public class BookQuestion: EntityBase,IEntity
    {
        public string QuestionText { get; set; }
        public string OptionsOne { get; set; }
        public string OptionsTwo { get; set; }
    }
}
