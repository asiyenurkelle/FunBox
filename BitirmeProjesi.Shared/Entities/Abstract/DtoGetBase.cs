using BitirmeProjesi.Shared.Utilities.Results.Complex_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BitirmeProjesi.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        //bütün dto larınget işlemlerini burdan yöneticez.
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }

        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 3;
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;

    }
}
