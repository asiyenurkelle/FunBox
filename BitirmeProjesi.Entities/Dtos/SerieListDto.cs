using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class SerieListDto:DtoGetBase
    {
        public IList<Serie> Series { get; set; }
        
    }
}
