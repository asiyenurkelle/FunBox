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
    public class MovieQuestionMap : IEntityTypeConfiguration<MovieQuestion>
    {
        public void Configure(EntityTypeBuilder<MovieQuestion> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Id).ValueGeneratedOnAdd();
            builder.Property(q => q.QuestionText).IsRequired();
            builder.Property(q => q.OptionsOne).IsRequired();
            builder.Property(q => q.OptionsTwo).IsRequired();

            builder.ToTable("MovieQuestions");

            builder.HasData(new MovieQuestion
            {
                Id=1,
                QuestionText="Film izlerken sıkılmadan devam edebildiğin ideal süren aşağıdakilerden hangisine daha yakındır?" ,
                OptionsOne="2 saat veya daha kısa",
                OptionsTwo="2 saatten daha uzun"
                
            });
            
            builder.HasData(new MovieQuestion
            {
                Id = 2,
                QuestionText = "Senin için bir filmin IMDb puanı önemli midir?",
                OptionsOne = "Evet, 7 ve üzeri olmalı",
                OptionsTwo = "Hayır, farketmez"

            });
            builder.HasData(new MovieQuestion
            {
                Id = 3,
                QuestionText = "Eski tarihli filmleri izlemekten hoşlanır mısın?",
                OptionsOne = "Evet,1990 ve öncesi yapımlar",
                OptionsTwo = "Günümüz ve yakın tarihler"

            });
        }
    }
}
