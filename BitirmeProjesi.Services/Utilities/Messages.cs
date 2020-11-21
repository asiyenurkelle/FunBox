using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Services.Utilities
{
    public static class Messages
    {
        public static class Category
        {
            //isPlural ile coğul mu yokse tekil mi mesaj vermek istediğimizi ayarlıcaz.Kategoriler içerisinden kategori bulunamadı cogul metotlar icin.(GetAll gibi)
            //false ise tekil metotlara mesaj vermek için kullanırız.(get)
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiçbir kategori bulunamadı";
                return "Böyle bir kategori bulunamadı.";
            }
        }
        public static class Comment
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiçbir yorum bulunamadı";
                return "Böyle bir yorum bulunamadı.";
            }

            public static string Add(string commentTitle)
            {
                return $"{ commentTitle} başlıklı yorum başarıyla eklenmiştir.";
            }

            public static string Delete(string commentTitle)
            {
                return $"{ commentTitle}  başlıklı yorum başarıyla silinmiştir.";
            }
        }
        public static class Book
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiçbir kitap bulunamadı";
                return "Böyle bir kitap bulunamadı.";
            }
        }
        public static class Serie
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiçbir dizi bulunamadı";
                return "Böyle bir dizi bulunamadı.";
            }
        }
        public static class Movie
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiçbir film bulunamadı";
                return "Böyle bir film bulunamadı.";
            }
        }

    }
}
