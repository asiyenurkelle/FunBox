﻿using BitirmeProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Mappings
{
    public class SerieMap : IEntityTypeConfiguration<Serie>
    {
        public void Configure(EntityTypeBuilder<Serie> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.Title).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Subject).HasColumnType("NVARCHAR(MAX)").IsRequired();
            builder.Property(s => s.ThumbNail).IsRequired();

            builder.Property(s => s.Activities).HasColumnType("BİT");


            builder.HasOne<Category>(s => s.Category).WithMany(c => c.Series).HasForeignKey(s => s.CategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("Series");

            builder.HasData(new Serie
            {
                Id = 1,
                Title = "Peaky Blinders",
                Subject = "Peaky Blinders, İngiltere'nin Birmingham şehrinde çetelerin birbiriyle yaşadığı olayları izleyiciye aktarmaktadır. Çete için her şey tıkırında giderken son bir soygunda hata yapılır ve çetenin başına bela olacak bir müfettiş görevlendirilir.",
                CategoryId = 11,
                ThumbNail = "peakyblinders.jpg",
                Time = 58,
                Scenarist = "Steven Knigt",
                Production = "Yabancı",
                Activities = false,
                Imdb = 8.7,
                SeasonNumber = 6,
                Summary = "Birinci Dünya Savaşı sırasında devlete karşı gelen bahis çeteleri, komünistler ve devlet arasındaki husumeti konu alınıyor."


            },
            new Serie
            {
                Id = 2,
                Title = "The Outsider",
                Subject = "11 yaşında feci şekilde katledilen bir çocuğun cesedi parkta bulunur. Etraftaki görgü tanıkları ve cesedin üzerindeki bulgular, şehirde yaşayan saygın bir iş adamını işaret etmektedir. Bu kişi ise koçluk ve  İngilizce öğretmenliği yapan, aynı zamanda iyi bir eş ve kız babası olan Terry Maitland’dır.",
                CategoryId = 11,
                ThumbNail = "theoutsider.jpg",
                Time = 60,
                Scenarist = "Andrew Baldwin",
                Production = "Yabancı",
                Activities = false,
                Imdb = 6.3,
                SeasonNumber = 1,
                Summary = "11 yaşındaki bir çocuğun hunharca katledilen cesedi bir parkta bulunur."

            },
            new Serie
            {
                Id = 3,
                Title = "The Witcher",
                Subject = "Fantastik bir dizi olan The Witcher’da, çok uzun yıllardır barış içerisinde yaşayan insanlar, cüceler ve elfler artık savaş halindedir. Ana karakterimiz The Witcher lakaplı Geralt of Rivia ise acımasız bir suikastçıdır. Kendisi durumun farkında olmasa da aslında kendisine vaadedilen bir kız çocuğu bu dünya düzenini değiştirecektir.",
                CategoryId = 6,
                ThumbNail = "thewitcher.jpg",
                Time = 60,
                Scenarist = "Lauren Schmidt Hissrich",
                Production = "Yabancı",
                Activities = false,
                Imdb = 8.4,
                SeasonNumber = 1,
                Summary = "Yüzyılı aşkın süredir bir arada yaşayan insanlar, cüceler ve elfler arasındaki barış sona erer ve yeni bir ırklar arası savaş patlak verir."
            },
            new Serie
            {
                Id = 4,
                Title = "You",
                Subject = "kitapçıda çalışan Joe ve o kitapçıya müşteri olarak gelen Beck’in hikayesini izleyiciye aktarmaktadır. Joe, Beck’e gördüğü andan itibaren aşık durumdadır ve onu korumak için ne gerekiyorsa yapmaktadır. Joe’nin Beck’e karşı takıntılı tavırlar göstermesi Beck’in yakın arkadaşı Peach’in dikkatini çekse de Joe’ye engel olmak mümkün değildir. Yaptığı her takıntılı davranışı Beck’e aşık olduğu için yaptığını düşünen Joe, aslında tam bir saplantı yaşamaktadır.",
                CategoryId = 6,
                ThumbNail = "you.jpg",
                Time = 45,
                Scenarist = "Blake Neely",
                Production = "Yabancı",
                Activities = false,
                Imdb = 7.7,
                SeasonNumber = 3,
                Summary = "Zeki bir New York'lu olan Joe, bir kitapçı işletmektedir. Bir gün kitapçıya gelen Beck,' Joe aşık olmuştur."
            },
            new Serie
            {
                Id = 5,
                Title = "Stranger Things",
                Subject = " Winona Ryder, David Harbour, Cara Buono'yu başrollerinde buluşturan dizide, kaybolan genç çocuk ve onu bulmaya çalışan ailenin yaşadıkları anlatılmaktadır.",
                CategoryId = 13,
                ThumbNail = "strangerthings.jpg",
                Time = 56,
                Scenarist = "Matt Duffer",
                Production = "Yabancı",
                Activities = false,
                Imdb = 8.7,
                SeasonNumber = 4,
                Summary = "Kaybolan genç bir çocuğu ve onu bulmaya çalışan annesini anlatıyor."
            },
            new Serie
            {
                Id = 6,
                Title = "Spartacus",
                Subject = "Trakyalılar çoğunlukla Trakya topraklarını yağmalayan Getae’ye karşı bir ayaklanma düzenleyerek Roma lejyonlarında yardımcı olarak görev yapacakları Claudius Glaber tarafından ikna edilmeye başlanmıştır. Bununla birlikte, Glaber, anlaşma konusunda ısrar ettikten sonra Getae’ten dikkatini Küçük Asya’daki Mithridates saldırısına çekmeyi başarır.",
                CategoryId = 4,
                ThumbNail = "spartacus.jpg",
                Time = 42,
                Scenarist = "Howard Fast",
                Production = "Yabancı",
                Activities = false,
                Imdb = 8.5,
                SeasonNumber = 3,
                Summary = "Blood and Sand, yurdundan ve sevdiği kadından koparılan bir adamın, kanlı arenalarda küllerinden doğuş öyküsünü anlatıyor. "

            }
            );
        }

    }
}
