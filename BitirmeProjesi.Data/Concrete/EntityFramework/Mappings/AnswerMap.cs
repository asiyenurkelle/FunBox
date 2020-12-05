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
    public class AnswerMap : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Options1).IsRequired();
            builder.Property(a => a.Options2).IsRequired();
           

            builder.ToTable("Answers");
            builder.HasData(new Answer
            {
                Id = 1,
                AnswerText = "1 saat",
                Options1 = "1 saatten kısa",
                Options2 = "1 saatten daha uzun",
               
            });
        }
    }
}
