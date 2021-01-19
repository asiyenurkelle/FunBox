using BitirmeProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Mappings
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {

            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.Title).HasMaxLength(100).IsRequired();

            builder.Property(m => m.ThumbNail).IsRequired();
            builder.Property(m => m.Subject).HasColumnType("NVARCHAR(MAX)").IsRequired();

            builder.Property(s => s.Activities).HasColumnType("BİT");



            builder.HasOne<Category>(m => m.Category).WithMany(c => c.Movies).HasForeignKey(m => m.CategoryId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Movies");

            builder.HasData(new Movie
            {
                Id = 1,
                Title = "Hababam Sınıfı",
                CategoryId = 10,
                Subject = "Öğrencilik hayatları haylazlık ve tembellik üzerine kurulu olan bir sınıf dolusu matrak öğrencinin, Özel Çamlıca Lisesi’nde yaşadığı yer yer eğlenceli, yer yer de dokunaklı öyküleri anlatan film, Hababam Sınıfı serisinin ilk filmidir",
                ThumbNail = "hababamsinifi.jpg",
                Time = 90,
                Scenarist = "Umur Bugay",
                Production = "Yerli",
                Imdb = 9.3,
                Activities = false,
                Summary = "Değişik şehirlerden gelen, değişik düşünceleri olan, uslanmaz, haylaz bir sınıfın öğrencileri ve onların başlarına gelen olaylar anlatılmaktadır."
            },
            new Movie
            {
                Id = 2,
                Title = "The Godfather",
                CategoryId = 1,
                Subject = "Baba, 40’lar ve 50’lerin Amerika’sında, bir İtalyan mafya ailesinin destansı öyküsünü konu alıyor. Don Corleone’nin kızı Connie’nin düğününde, ailenin en küçük oğlu ve bir savaş gazisi olan Michael babasıyla barışır. Bir suikast girişimi, Don’u artık işleri yönetemeyecek duruma düşürünce, ailenin başına Michael ve ağabeyi Sonny geçer.",
                ThumbNail = "thegodfather.jpg",
                Time = 178,
                Scenarist = "Mario Puzo",
                Production = "Yabancı",
                Imdb = 7.6,
                Activities = false,
                Summary = "Baba, 40’lar ve 50’lerin Amerika’sında, bir İtalyan mafya ailesinin destansı öyküsünü konu alıyor."

            },
            new Movie
            {
                Id = 3,
                Title = "Braveheart",
                CategoryId = 11,
                Subject = "Cesuryürek'te, William Wallace yaşanan büyük acılar sonrası yeniden memleketi olan İskoçya’ya döner. Onun asıl amacı çiftçilik yaparak sakin bir hayat sürmektir. Çocukluk aşkıyla karşılaştığında bunun onu dipsiz bir uçuruma iteceğinin farkında değildir.",
                ThumbNail = "braveheart.jpg",
                Time = 182,
                Scenarist = "Randall Wallace",
                Production = "Yabancı",
                Imdb = 8.3,
                Activities = false,
                Summary = "ngilizler, 13. yüzyılda İskoçların üstünde egemenlik kurmuştur. İngiliz soyluların, yeni evlenmiş İskoç kadınları ile ilk geceyi geçirme hakkı bulunmaktadır."

            },
            new Movie
            {
                Id = 4,
                Title = "Eşkiya",
                CategoryId = 11,
                Subject = "Eşkiya, hapse düşmesine neden olan arkadaşının peşine düşen bir adamın hikayesini anlatıyor. 35 yıl önce Cudi dağlarında bir grup eşkiya yakalandı ve hapse atıldı. Yıllar içinde kimi hastalıktan, kimi hesaplaşma sonucu öldü. Biri hariç... 35 yıl sonra Hapisten çıkınca Baran’ ın ilk işi köyüne dönmek olur.",
                ThumbNail = "eskiya.jpg",
                Time = 128,
                Scenarist = "Yavuz Turgul",
                Production = "Yerli",
                Imdb = 7.3,
               Activities=false,
               Summary= "Hapse düşmesine neden olan arkadaşının peşine düşen bir adamın hikayesini anlatıyor."

            },
             new Movie
             {
                 Id = 5,
                 Title = "Bir Rüya İçin Ağıt",
                 CategoryId = 11,
                 Subject = "Uyuşturucu bağımlısı bir genç, televizyon bağımlısı annesi ve aralarında günden güne yükselen bir uçurum.Uyuşturucu batağı içerisindeki Harry’nin hayattaki tek amacı daha fazla uyuşturucuyken, umutsuz annesini hayata bağlayan tek şey en sevdiği yarışma programıdır.",
                 ThumbNail = "birruyaicinagit.jpg",
                 Time = 102,
                 Scenarist = "Darren Aronofsky",
                 Production = "Yabancı",
                 Imdb = 8.6,
                 Activities = false,
                 Summary = "Uyuşturucu bağımlısı bir genç, televizyon bağımlısı annesi ve aralarında günden güne yükselen bir uçurum."

             }

            );
        }
    }
}
