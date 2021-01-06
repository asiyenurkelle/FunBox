using BitirmeProjesi.Entities.Concrete;
using BitirmeProjesi.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Mappings
{
    public class BookCommentMap : IEntityTypeConfiguration<BookComment>
    {
        public void Configure(EntityTypeBuilder<BookComment> builder)
        {

            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.Title).HasMaxLength(100).IsRequired();
            builder.Property(m => m.Subject).HasColumnType("NVARCHAR(MAX)").IsRequired();
            //builder.Property(m => m.Name).HasMaxLength(100).IsRequired();


            builder.HasOne<Book>(c => c.Book).WithMany(m => m.BookComments).HasForeignKey(c => c.BookId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("BookComments");
        }
    }
}
