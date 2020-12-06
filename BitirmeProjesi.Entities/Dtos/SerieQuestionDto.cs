using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entities.Dtos
{
    public class SerieQuestionDto:DtoGetBase
    {
        public IList<SerieQuestion> SerieQuestions { get; set; }
    }
}
