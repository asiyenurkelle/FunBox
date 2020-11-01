using BitirmeProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasMaxLength(70).IsRequired();
            builder.ToTable("Categories");


            builder.HasData(new Category
            {
                Id = 1,
                Name = "Polisiye"
            }, 
            new Category { 
                Id=2,
                Name="Roman"
            },
            new Category
            {
                Id=3,
                Name="Hikaye"
            },
            new Category
            {
                Id=4,
                Name="Bilim Kurgu"
            },
            new Category
            {
                Id=5,
                Name="Aksiyon"
            },
            new Category {
                Id=6,
                Name="Macera"
            },
            new Category {
                Id=7,
                Name="Psikoloji"
            },
            new Category
            {
                Id=8,
                Name="Siyaset"
            },
            new Category
            {
                Id=9,
                Name="Tarih"
            },
            new Category
            {
                Id=10,
                Name="Komedi"
            },
            new Category
            {
                Id=11,
                Name="Dram"
            },
            new Category
            {
                Id=12,
                Name="Romantik"
            },
            new Category
            {
               Id=13,
               Name="Korku"
            }
            );
        }
    }
} 
