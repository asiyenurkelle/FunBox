﻿// <auto-generated />
using System;
using BitirmeProjesi.Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BitirmeProjesi.Data.Migrations
{
    [DbContext(typeof(BitirmeProjesiContext))]
    partial class BitirmeProjesiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Activities")
                        .HasColumnType("BİT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Page")
                        .HasColumnType("int");

                    b.Property<string>("Production")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("ThumbNail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activities = false,
                            CategoryId = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Page = 192,
                            Production = "Yabancı",
                            Subject = "Her birinin gizledikleri ve korktukları sırları olan on kişi, Zenci Adası’ndaki ıssız bir malikâneye davet edilirler. Ancak malikâneye giden grubu bir sürpriz beklemektedir, ev sahibi ortalarda yoktur. Geçmişlerindeki karanlık sırlardan başka hiçbir şeyleri olmayan bu insanlar adada mahsur kalmışlardır. Konuklar bir süre sonra gizledikleri sırları birbirlerine anlatırlar. Ve teker teker ölmeye başlarlar.",
                            ThumbNail = "onkucukzenci.jpg",
                            Title = "On Küçük Zenci",
                            Writer = "Agatha Christie"
                        },
                        new
                        {
                            Id = 2,
                            Activities = false,
                            CategoryId = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Page = 256,
                            Production = "Yabancı",
                            Subject = "Gece yarısından sonra artan şiddetli tipi yüzünden Doğu Ekspresi artık yoluna devam edemeyecek durumdadır. Yılın bu zamanlarında lüks tren tamamen doludur. Ertesi sabah yapılan kontroller sonucu tüm yolcuların sağsalim trende olduğu anlaşılır. Ancak defalarca bıçaklanarak öldürülen Amerikalı yolcunun kompartımanının kapısı içeriden kilitlidir.",
                            ThumbNail = "doguekspresindecinayet.jpg",
                            Title = "Doğu Ekspresinde Cinayet",
                            Writer = "Agatha Christie"
                        },
                        new
                        {
                            Id = 3,
                            Activities = false,
                            CategoryId = 2,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Page = 536,
                            Production = "Yabancı",
                            Subject = "Genç adam, aniden üç büyük dinin temsilcilerine döndü. “Şaşırtıcı bulacağınızı tahmin ettiğim bilimsel bir buluşum sebebiyle bugün buradayım. İnsanlık deneyimimizin en temel iki sorusuna cevap bulma ümidi ile yıllardır peşinden koşuyordum. Bu bilginin tüm inananları derinden etkileyeceğine inanıyorum. Nasıl desem, ‘yıkıcı’ diye tanımlanabilecek bir değişikliğe sebep olabilir.",
                            ThumbNail = "baslangic.jpg",
                            Title = "Başlangıç",
                            Writer = "Dan Brown"
                        },
                        new
                        {
                            Id = 4,
                            Activities = false,
                            CategoryId = 2,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Page = 495,
                            Production = "Yabancı",
                            Subject = "Dan Brown, ülkedeki birkaç usta yazardan biri. Da Vinci Şifresi üstün bir zeka tarafından kurgulanmış harika bir gerilim romanı.Entrika ve tehlikenin iç içe geçtiği okuduğum en iyi gerilim romanı. Kelime oyunları, gizemler ve bulmacalarla örülmüş akıllara durgunluk veren bir öykü.",
                            ThumbNail = "davincisifresi.jpg",
                            Title = "Da Vinci Şifresi",
                            Writer = "Dan Brown"
                        },
                        new
                        {
                            Id = 5,
                            Activities = false,
                            CategoryId = 4,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Page = 456,
                            Production = "Yerli",
                            Subject = "Masal tadındaki bu fantastik kurgu,okuyucuyu bir zaman yolculuğuna çıkarır.Okuyucunun çözebileceği küçük süprizlerin gizlendiği tarihin değişik zamanlarındaki yaşanmışlıkları,aynı zaman sürecinde yaşatan bu eser,ayrıca gizemli bir aşkın romanıdır.",
                            ThumbNail = "adaletsavascilari.jpg",
                            Title = "Adalet Savaşçıları",
                            Writer = "Bahri Akkoç"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

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
                        .UseIdentityColumn();

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
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                        .UseIdentityColumn();

                    b.Property<bool>("Activities")
                        .HasColumnType("BİT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activities = false,
                            CategoryId = 10,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yerli",
                            Scenarist = "Umur Bugay",
                            Subject = "Öğrencilik hayatları haylazlık ve tembellik üzerine kurulu olan bir sınıf dolusu matrak öğrencinin, Özel Çamlıca Lisesi’nde yaşadığı yer yer eğlenceli, yer yer de dokunaklı öyküleri anlatan film, Hababam Sınıfı serisinin ilk filmidir",
                            ThumbNail = "hababamsinifi.jpg",
                            Time = "1 saat 30 dakika",
                            Title = "Hababam Sınıfı"
                        },
                        new
                        {
                            Id = 2,
                            Activities = false,
                            CategoryId = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yabancı",
                            Scenarist = "Mario Puzo",
                            Subject = "Baba, 40’lar ve 50’lerin Amerika’sında, bir İtalyan mafya ailesinin destansı öyküsünü konu alıyor. Don Corleone’nin kızı Connie’nin düğününde, ailenin en küçük oğlu ve bir savaş gazisi olan Michael babasıyla barışır. Bir suikast girişimi, Don’u artık işleri yönetemeyecek duruma düşürünce, ailenin başına Michael ve ağabeyi Sonny geçer.",
                            ThumbNail = "thegodfather.jpg",
                            Time = "2 saat 58 dakika",
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 3,
                            Activities = false,
                            CategoryId = 11,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yabancı",
                            Scenarist = "Randall Wallace",
                            Subject = "Cesuryürek'te, William Wallace yaşanan büyük acılar sonrası yeniden memleketi olan İskoçya’ya döner. Onun asıl amacı çiftçilik yaparak sakin bir hayat sürmektir. Çocukluk aşkıyla karşılaştığında bunun onu dipsiz bir uçuruma iteceğinin farkında değildir.",
                            ThumbNail = "braveheart.jpg",
                            Time = "3 saat 2 dakika",
                            Title = "Braveheart"
                        },
                        new
                        {
                            Id = 4,
                            Activities = false,
                            CategoryId = 11,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yerli",
                            Scenarist = "Yavuz Turgul",
                            Subject = "Eşkiya, hapse düşmesine neden olan arkadaşının peşine düşen bir adamın hikayesini anlatıyor. 35 yıl önce Cudi dağlarında bir grup eşkiya yakalandı ve hapse atıldı. Yıllar içinde kimi hastalıktan, kimi hesaplaşma sonucu öldü. Biri hariç... 35 yıl sonra Hapisten çıkınca Baran’ ın ilk işi köyüne dönmek olur.",
                            ThumbNail = "eskiya.jpg",
                            Time = "2 saat 8 dakika",
                            Title = "Eşkiya"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Activities")
                        .HasColumnType("BİT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Series");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activities = false,
                            CategoryId = 11,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yabancı",
                            Scenarist = "Steven Knigt",
                            Subject = "Peaky Blinders, İngiltere'nin Birmingham şehrinde çetelerin birbiriyle yaşadığı olayları izleyiciye aktarmaktadır. Çete için her şey tıkırında giderken son bir soygunda hata yapılır ve çetenin başına bela olacak bir müfettiş görevlendirilir.",
                            ThumbNail = "peakyblinders.jpg",
                            Time = "58 dakika",
                            Title = "Peaky Blinders"
                        },
                        new
                        {
                            Id = 2,
                            Activities = false,
                            CategoryId = 11,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yabancı",
                            Scenarist = "Andrew Baldwin",
                            Subject = "11 yaşında feci şekilde katledilen bir çocuğun cesedi parkta bulunur. Etraftaki görgü tanıkları ve cesedin üzerindeki bulgular, şehirde yaşayan saygın bir iş adamını işaret etmektedir. Bu kişi ise koçluk ve  İngilizce öğretmenliği yapan, aynı zamanda iyi bir eş ve kız babası olan Terry Maitland’dır.",
                            ThumbNail = "theoutsider.jpg",
                            Time = "1 saat",
                            Title = "The Outsider"
                        },
                        new
                        {
                            Id = 3,
                            Activities = false,
                            CategoryId = 6,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yabancı",
                            Scenarist = "Lauren Schmidt Hissrich",
                            Subject = "Fantastik bir dizi olan The Witcher’da, çok uzun yıllardır barış içerisinde yaşayan insanlar, cüceler ve elfler artık savaş halindedir. Ana karakterimiz The Witcher lakaplı Geralt of Rivia ise acımasız bir suikastçıdır. Kendisi durumun farkında olmasa da aslında kendisine vaadedilen bir kız çocuğu bu dünya düzenini değiştirecektir.",
                            ThumbNail = "thewitcher.jpg",
                            Time = "1 saat",
                            Title = "The Witcher"
                        },
                        new
                        {
                            Id = 4,
                            Activities = false,
                            CategoryId = 6,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yabancı",
                            Scenarist = "Blake Neely",
                            Subject = "kitapçıda çalışan Joe ve o kitapçıya müşteri olarak gelen Beck’in hikayesini izleyiciye aktarmaktadır. Joe, Beck’e gördüğü andan itibaren aşık durumdadır ve onu korumak için ne gerekiyorsa yapmaktadır. Joe’nin Beck’e karşı takıntılı tavırlar göstermesi Beck’in yakın arkadaşı Peach’in dikkatini çekse de Joe’ye engel olmak mümkün değildir. Yaptığı her takıntılı davranışı Beck’e aşık olduğu için yaptığını düşünen Joe, aslında tam bir saplantı yaşamaktadır.",
                            ThumbNail = "you.jpg",
                            Time = "45 dakika",
                            Title = "You"
                        },
                        new
                        {
                            Id = 5,
                            Activities = false,
                            CategoryId = 13,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yabancı",
                            Scenarist = "Matt Duffer",
                            Subject = " Winona Ryder, David Harbour, Cara Buono'yu başrollerinde buluşturan dizide, kaybolan genç çocuk ve onu bulmaya çalışan ailenin yaşadıkları anlatılmaktadır.",
                            ThumbNail = "strangerthings.jpg",
                            Time = "56 dakika",
                            Title = "Stranger Things"
                        },
                        new
                        {
                            Id = 6,
                            Activities = false,
                            CategoryId = 4,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Production = "Yabancı",
                            Scenarist = "Howard Fast",
                            Subject = "Trakyalılar çoğunlukla Trakya topraklarını yağmalayan Getae’ye karşı bir ayaklanma düzenleyerek Roma lejyonlarında yardımcı olarak görev yapacakları Claudius Glaber tarafından ikna edilmeye başlanmıştır. Bununla birlikte, Glaber, anlaşma konusunda ısrar ettikten sonra Getae’ten dikkatini Küçük Asya’daki Mithridates saldırısına çekmeyi başarır.",
                            ThumbNail = "spartacus.jpg",
                            Time = "42 dakika",
                            Title = "Spartacus"
                        });
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Book", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Book", "Book")
                        .WithMany("Comments")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BitirmeProjesi.Entities.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BitirmeProjesi.Entities.Concrete.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BitirmeProjesi.Entities.Concrete.Serie", "Serie")
                        .WithMany("Comments")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");

                    b.Navigation("Movie");

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Movie", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.RoleClaim", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Serie", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Category", "Category")
                        .WithMany("Series")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.UserClaim", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.UserLogin", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.UserRole", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BitirmeProjesi.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.UserToken", b =>
                {
                    b.HasOne("BitirmeProjesi.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Book", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Movies");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Movie", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BitirmeProjesi.Entities.Concrete.Serie", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
