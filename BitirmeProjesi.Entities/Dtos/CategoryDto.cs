using System;
using System.Collections.Generic;
using System.Text;
using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;

namespace BitirmeProjesi.Entities.Dtos
{
    public class CategoryDto:DtoGetBase
    {
        public Category Category { get; set; }
        
    }
}
