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
    public class MovieCommentMap : IEntityTypeConfiguration<MovieComment>
    {
        public void Configure(EntityTypeBuilder<MovieComment> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.Title).HasMaxLength(100).IsRequired();
            builder.Property(m => m.Subject).HasColumnType("NVARCHAR(MAX)").IsRequired();
            //builder.Property(m => m.Name).HasMaxLength(100).IsRequired();


            builder.HasOne<Movie>(c => c.Movie).WithMany(m => m.MovieComments).HasForeignKey(c => c.MovieId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("MovieComments");
        }
    }
}
