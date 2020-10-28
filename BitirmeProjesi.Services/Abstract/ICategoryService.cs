using BitirmeProjesi.Shared.Utilities.Results.Abstract;
using BitirmeProjesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();
        //KATEGORİ EKLEME VE GÜNCELLEME KISMI DİĞER SERVİSLERDE LAZIM OLABİLİR BURDA GEREK YOK.
        //Task<IResult> Add(CategoryAddDto) categoryAddDto, string createdByName);
        //Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        
        //delete ile sadece isdeleted olanlar gelmicek.harddelete ile db'den de silincekler.
        Task<IResult> Delete(int categoryId);
        
        

    }
}
