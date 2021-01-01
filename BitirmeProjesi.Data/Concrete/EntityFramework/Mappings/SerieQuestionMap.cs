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
    public class SerieQuestionMap : IEntityTypeConfiguration<SerieQuestion>
    {
        public void Configure(EntityTypeBuilder<SerieQuestion> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Id).ValueGeneratedOnAdd();
            builder.Property(q => q.QuestionText).IsRequired();
            builder.Property(q => q.OptionsOne).IsRequired();
            builder.Property(q => q.OptionsTwo).IsRequired();

            builder.ToTable("SerieQuestions");

            builder.HasData(new SerieQuestion
            {
                Id=1,
                QuestionText="Dizi izlerken sıkılmadan devam edebildiğin ideal süren aşağıdakilerden hangisine daha yakındır?" ,
                OptionsOne="1 saat veya daha kısa",
                OptionsTwo="1 saatten daha uzun"
                
            });
            builder.HasData(new SerieQuestion
            {
                Id = 2,
                QuestionText = "Senin için bir dizinin IMDb puanı önemli midir?",
                OptionsOne = "Evet,7 ve üzeri olmalı",
                OptionsTwo = "Hayır bu benim için bir kriter değil"

            });
            builder.HasData(new SerieQuestion
            {
                Id = 3,
                QuestionText = "Kaç sezonluk dizileri izlemeyi tercih edersin?",
                OptionsOne = "5 sezon ve daha az",
                OptionsTwo = "5 sezondan daha fazla"

            });


        }
    }
}
