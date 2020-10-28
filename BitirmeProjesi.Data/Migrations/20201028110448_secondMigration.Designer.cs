﻿// <auto-generated />
using System;
using BitirmeProjesi.Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BitirmeProjesi.Data.Migrations
{
    [DbContext(typeof(BitirmeProjesiContext))]
    [Migration("20201028110448_secondMigration")]
    partial class secondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Page")
                        .HasColumnType("int");

                    b.Property<string>("Production")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnName("NVARCHAR(MAX)")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbNail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Page = 192,
                            Production = "Yabancı",
                            Subject = "Her birinin gizledikleri ve korktukları sırları olan on kişi, Zenci Adası’ndaki ıssız bir malikâneye davet edilirler. Ancak malikâneye giden grubu bir sürpriz beklemektedir, ev sahibi ortalarda yoktur. Geçmişlerindeki karanlık sırlardan başka hiçbir şeyleri olmayan bu insanlar adada mahsur kalmışlardır. Konuklar bir süre sonra gizledikleri sırları birbirlerine anlatırlar. Ve teker teker ölmeye başlarlar.",
                            ThumbNail = "default.jpg",
                            Title = "On Küçük Zenci",
                            Writer = "Agatha Christie"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Page = 256,
                            Production = "Yabancı",
                            Subject = "Gece yarısından sonra artan şiddetli tipi yüzünden Doğu Ekspresi artık yoluna devam edemeyecek durumdadır. Yılın bu zamanlarında lüks tren tamamen doludur. Ertesi sabah yapılan kontroller sonucu tüm yolcuların sağsalim trende olduğu anlaşılır. Ancak defalarca bıçaklanarak öldürülen Amerikalı yolcunun kompartımanının kapısı içeriden kilitlidir.",
                            ThumbNail = "default.jpg",
                            Title = "Doğu Ekspresinde Cinayet",
                            Writer = "Agatha Christie"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Page = 536,
                            Production = "Yabancı",
                            Subject = "Genç adam, aniden üç büyük dinin temsilcilerine döndü. “Şaşırtıcı bulacağınızı tahmin ettiğim bilimsel bir buluşum sebebiyle bugün buradayım. İnsanlık deneyimimizin en temel iki sorusuna cevap bulma ümidi ile yıllardır peşinden koşuyordum. Bu bilginin tüm inananları derinden etkileyeceğine inanıyorum. Nasıl desem, ‘yıkıcı’ diye tanımlanabilecek bir değişikliğe sebep olabilir.",
                            ThumbNail = "default.jpg",
                            Title = "Başlangıç",
                            Writer = "Dan Brown"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Page = 495,
                            Production = "Yabancı",
                            Subject = "Dan Brown, ülkedeki birkaç usta yazardan biri. Da Vinci Şifresi üstün bir zeka tarafından kurgulanmış harika bir gerilim romanı.Entrika ve tehlikenin iç içe geçtiği okuduğum en iyi gerilim romanı. Kelime oyunları, gizemler ve bulmacalarla örülmüş akıllara durgunluk veren bir öykü.",
                            ThumbNail = "default.jpg",
                            Title = "Da Vinci Şifresi",
                            Writer = "Dan Brown"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Page = 456,
                            Production = "Yerli",
                            Subject = "Masal tadındaki bu fantastik kurgu,okuyucuyu bir zaman yolculuğuna çıkarır.Okuyucunun çözebileceği küçük süprizlerin gizlendiği tarihin değişik zamanlarındaki yaşanmışlıkları,aynı zaman sürecinde yaşatan bu eser,ayrıca gizemli bir aşkın romanıdır.",
                            ThumbNail = "default.jpg",
                            Title = "Adalet Savaşçıları",
                            Writer = "Bahri Akkoç"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Polisiye"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hikaye"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bilim Kurgu"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Aksiyon"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Macera"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Psikoloji"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Siyaset"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tarih"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Komedi"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Dram"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Romantik"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Korku"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("SerieId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MovieId");

                    b.HasIndex("SerieId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Production")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scenarist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnName("NVARCHAR(MAX)")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbNail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 10,
                            Production = "Yerli",
                            Scenarist = "Umur Bugay",
                            Subject = "Öğrencilik hayatları haylazlık ve tembellik üzerine kurulu olan bir sınıf dolusu matrak öğrencinin, Özel Çamlıca Lisesi’nde yaşadığı yer yer eğlenceli, yer yer de dokunaklı öyküleri anlatan film, Hababam Sınıfı serisinin ilk filmidir",
                            ThumbNail = "default.jpg",
                            Time = 90,
                            Title = "Hababam Sınıfı"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Production = "Yabancı",
                            Scenarist = "Mario Puzo",
                            Subject = "Baba, 40’lar ve 50’lerin Amerika’sında, bir İtalyan mafya ailesinin destansı öyküsünü konu alıyor. Don Corleone’nin kızı Connie’nin düğününde, ailenin en küçük oğlu ve bir savaş gazisi olan Michael babasıyla barışır. Bir suikast girişimi, Don’u artık işleri yönetemeyecek duruma düşürünce, ailenin başına Michael ve ağabeyi Sonny geçer.",
                            ThumbNail = "default.jpg",
                            Time = 178,
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 11,
                            Production = "Yabancı",
                            Scenarist = "Randall Wallace",
                            Subject = "Cesuryürek'te, William Wallace yaşanan büyük acılar sonrası yeniden memleketi olan İskoçya’ya döner. Onun asıl amacı çiftçilik yaparak sakin bir hayat sürmektir. Çocukluk aşkıyla karşılaştığında bunun onu dipsiz bir uçuruma iteceğinin farkında değildir.",
                            ThumbNail = "default.jpg",
                            Time = 182,
                            Title = "Braveheart"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 11,
                            Production = "Yerli",
                            Scenarist = "Yavuz Turgul",
                            Subject = "Eşkiya, hapse düşmesine neden olan arkadaşının peşine düşen bir adamın hikayesini anlatıyor. 35 yıl önce Cudi dağlarında bir grup eşkiya yakalandı ve hapse atıldı. Yıllar içinde kimi hastalıktan, kimi hesaplaşma sonucu öldü. Biri hariç... 35 yıl sonra Hapisten çıkınca Baran’ ın ilk işi köyüne dönmek olur.",
                            ThumbNail = "default.jpg",
                            Time = 128,
                            Title = "Eşkiya"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Production")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scenarist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("ThumbNail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Series");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 11,
                            Production = "Yabancı",
                            Scenarist = "Steven Knigt",
                            Subject = "Peaky Blinders, İngiltere'nin Birmingham şehrinde çetelerin birbiriyle yaşadığı olayları izleyiciye aktarmaktadır. Çete için her şey tıkırında giderken son bir soygunda hata yapılır ve çetenin başına bela olacak bir müfettiş görevlendirilir.",
                            ThumbNail = "default.jpg",
                            Time = 58,
                            Title = "Peaky Blinders"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 11,
                            Production = "Yabancı",
                            Scenarist = "Andrew Baldwin",
                            Subject = "11 yaşında feci şekilde katledilen bir çocuğun cesedi parkta bulunur. Etraftaki görgü tanıkları ve cesedin üzerindeki bulgular, şehirde yaşayan saygın bir iş adamını işaret etmektedir. Bu kişi ise koçluk ve  İngilizce öğretmenliği yapan, aynı zamanda iyi bir eş ve kız babası olan Terry Maitland’dır.",
                            ThumbNail = "default.jpg",
                            Time = 60,
                            Title = "The Outsider"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 6,
                            Production = "Yabancı",
                            Scenarist = "Lauren Schmidt Hissrich",
                            Subject = "Fantastik bir dizi olan The Witcher’da, çok uzun yıllardır barış içerisinde yaşayan insanlar, cüceler ve elfler artık savaş halindedir. Ana karakterimiz The Witcher lakaplı Geralt of Rivia ise acımasız bir suikastçıdır. Kendisi durumun farkında olmasa da aslında kendisine vaadedilen bir kız çocuğu bu dünya düzenini değiştirecektir.",
                            ThumbNail = "default.jpg",
                            Time = 60,
                            Title = "The Witcher"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 6,
                            Production = "Yabancı",
                            Scenarist = "Blake Neely",
                            Subject = "kitapçıda çalışan Joe ve o kitapçıya müşteri olarak gelen Beck’in hikayesini izleyiciye aktarmaktadır. Joe, Beck’e gördüğü andan itibaren aşık durumdadır ve onu korumak için ne gerekiyorsa yapmaktadır. Joe’nin Beck’e karşı takıntılı tavırlar göstermesi Beck’in yakın arkadaşı Peach’in dikkatini çekse de Joe’ye engel olmak mümkün değildir. Yaptığı her takıntılı davranışı Beck’e aşık olduğu için yaptığını düşünen Joe, aslında tam bir saplantı yaşamaktadır.",
                            ThumbNail = "default.jpg",
                            Time = 45,
                            Title = "You"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 13,
                            Production = "Yabancı",
                            Scenarist = "Matt Duffer",
                            Subject = " Winona Ryder, David Harbour, Cara Buono'yu başrollerinde buluşturan dizide, kaybolan genç çocuk ve onu bulmaya çalışan ailenin yaşadıkları anlatılmaktadır.",
                            ThumbNail = "default.jpg",
                            Time = 56,
                            Title = "Stranger Things"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Production = "Yabancı",
                            Scenarist = "Howard Fast",
                            Subject = "Trakyalılar çoğunlukla Trakya topraklarını yağmalayan Getae’ye karşı bir ayaklanma düzenleyerek Roma lejyonlarında yardımcı olarak görev yapacakları Claudius Glaber tarafından ikna edilmeye başlanmıştır. Bununla birlikte, Glaber, anlaşma konusunda ısrar ettikten sonra Getae’ten dikkatini Küçük Asya’daki Mithridates saldırısına çekmeyi başarır.",
                            ThumbNail = "default.jpg",
                            Time = 42,
                            Title = "Spartacus"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "asiyekelle7@gmail.com",
                            FirstName = "Asiye Nur",
                            LastName = "Kelle",
                            PasswordHash = new byte[] { 32, 102, 49, 98, 51, 99, 49, 98, 52, 99, 48, 51, 51, 53, 101, 54, 57, 48, 54, 101, 101, 48, 100, 99, 102, 57, 54, 100, 48, 98, 54, 49, 55 },
                            Picture = "default.jpg",
                            UserName = "asiyenurkelle"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Book", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Book", "Book")
                        .WithMany("Comments")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BitirmeProjesi.Entities.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BitirmeProjesi.Entities.Concrete.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BitirmeProjesi.Entities.Concrete.Serie", "Serie")
                        .WithMany("Comments")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Movie", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Serie", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Category", "Category")
                        .WithMany("Series")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
