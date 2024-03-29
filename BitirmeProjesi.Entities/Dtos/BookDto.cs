﻿using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Entities.Dtos
{
    public class BookDto:DtoGetBase
    {
        public Book Book { get; set; }
        public IList<Category> Categories { get; set; }
        public User User { get; set; }
    }
}
