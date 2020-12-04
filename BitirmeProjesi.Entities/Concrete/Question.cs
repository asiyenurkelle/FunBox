using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Concrete
{
    public class Question: EntityBase,IEntity
    {
        public string QuestionText { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
