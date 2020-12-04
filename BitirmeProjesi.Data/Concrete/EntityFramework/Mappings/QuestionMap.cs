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
    public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Id).ValueGeneratedOnAdd();
            builder.Property(q => q.QuestionText).IsRequired();

            builder.HasOne<Answer>(a => a.Answer).WithOne(a => a.Question).HasForeignKey<Question>(q => q.AnswerId);

            builder.ToTable("Questions");

            builder.HasData(new Question
            {
                Id=1,
                AnswerId=1,
                QuestionText="Film izlerken sıkılmadan devam edebildiğin ideal süren aşağıdakilerden hangisine daha yakındır?"  
            });
        }
    }
}
