using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Concrete
{
    public class Answer: EntityBase,IEntity
    {
        public string AnswerText { get; set; }
        public string Options1 { get; set; }
        public string Options2 { get; set; }
        public Question Question { get; set; }
    }
}
