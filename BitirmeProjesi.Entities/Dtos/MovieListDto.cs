using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class MovieListDto:DtoGetBase
    {
        public IList<Movie> Movies { get; set; }
      
    }
}
