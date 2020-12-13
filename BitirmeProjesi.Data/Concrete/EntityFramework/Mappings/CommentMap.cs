using BitirmeProjesi.Entities.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            //builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Title).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Subject).HasMaxLength(500).IsRequired();

            builder.HasOne<Movie>(c => c.Movie).WithMany(m => m.Comments).HasForeignKey(c => c.MovieId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Serie>(c => c.Serie).WithMany(s => s.Comments).HasForeignKey(c => c.SerieId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Book>(c => c.Book).WithMany(b => b.Comments).HasForeignKey(c => c.BookId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("Comments");

            }
            
        }
    }

