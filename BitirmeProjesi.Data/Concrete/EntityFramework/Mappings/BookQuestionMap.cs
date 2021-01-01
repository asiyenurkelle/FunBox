using BitirmeProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Mappings
{
    public class BookQuestionMap : IEntityTypeConfiguration<BookQuestion>
    {
        public void Configure(EntityTypeBuilder<BookQuestion> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Id).ValueGeneratedOnAdd();
            builder.Property(q => q.QuestionText).IsRequired();
            builder.Property(q => q.OptionsOne).IsRequired();
            builder.Property(q => q.OptionsTwo).IsRequired();

            builder.ToTable("BookQuestions");

            builder.HasData(new BookQuestion
            {
                Id=1,
                QuestionText="Kitap okurken sıkılmadan devam edebildiğin ideal sayfa sayısı aşağıdakilerden hangisine daha yakındır?" ,
                OptionsOne="200 sayfa ve altı",
                OptionsTwo="200 sayfadan daha fazla"
                
            });
            builder.HasData(new BookQuestion
            {
                Id = 2,
                QuestionText = "Dünya klasiklerini okumaktan hoşlanır mısınız?",
                OptionsOne = "Evet",
                OptionsTwo = "Hayır"

            });
            builder.HasData(new BookQuestion
            {
                Id = 3,
                QuestionText = "Eski tarihli kitapları okumaktan hoşlanır mısınız?",
                OptionsOne = "Evet eski tarihli kitaplar öncelikli tercihimdir",
                OptionsTwo = "Günümüze daha yakın tarihli kitapları tercih ederim"

            });

        }
    }
}
