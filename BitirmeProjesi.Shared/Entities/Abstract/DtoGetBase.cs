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
    }
}
