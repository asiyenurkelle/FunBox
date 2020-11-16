using BitirmeProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitirmeProjesi.Data.Concrete.EntityFramework.Mappings
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.Property(b => b.Title).HasMaxLength(100).IsRequired();
            builder.Property(b => b.Subject).HasColumnName("NVARCHAR(MAX)").IsRequired();
            builder.Property(b => b.ThumbNail).IsRequired();
            builder.Property(b => b.Page).IsRequired();
            builder.Property(b => b.Production).IsRequired();
            builder.HasOne<Category>(b => b.Category).WithMany(c => c.Books).HasForeignKey(b => b.CategoryId).OnDelete(DeleteBehavior.Restrict);
            
            builder.ToTable("Books");
            //İLK DEĞER ATAMALARI
            builder.HasData(new Book
            {
                Id = 1,
                Title = "On Küçük Zenci",
                ThumbNail = "onkucukzenci.jpg",
                Subject = "Her birinin gizledikleri ve korktukları sırları olan on kişi, Zenci Adası’ndaki ıssız bir malikâneye davet edilirler. Ancak malikâneye giden grubu bir sürpriz beklemektedir, ev sahibi ortalarda yoktur. Geçmişlerindeki karanlık sırlardan başka hiçbir şeyleri olmayan bu insanlar adada mahsur kalmışlardır. Konuklar bir süre sonra gizledikleri sırları birbirlerine anlatırlar. Ve teker teker ölmeye başlarlar.",
                CategoryId = 1,
                Page=192,
                Writer="Agatha Christie",
                Production="Yabancı"
            },
            new Book
            {
                Id = 2,
                Title="Doğu Ekspresinde Cinayet",
                ThumbNail = "doguekspesindecinayet.jpg",
                Subject = "Gece yarısından sonra artan şiddetli tipi yüzünden Doğu Ekspresi artık yoluna devam edemeyecek durumdadır. Yılın bu zamanlarında lüks tren tamamen doludur. Ertesi sabah yapılan kontroller sonucu tüm yolcuların sağsalim trende olduğu anlaşılır. Ancak defalarca bıçaklanarak öldürülen Amerikalı yolcunun kompartımanının kapısı içeriden kilitlidir.",
                CategoryId=1,
                Page=256,
                Writer="Agatha Christie",
                Production="Yabancı"
            },
            new Book
            {
                Id=3,
                Title="Başlangıç",
                ThumbNail = "baslangic.jpg",
                Subject = "Genç adam, aniden üç büyük dinin temsilcilerine döndü. “Şaşırtıcı bulacağınızı tahmin ettiğim bilimsel bir buluşum sebebiyle bugün buradayım. İnsanlık deneyimimizin en temel iki sorusuna cevap bulma ümidi ile yıllardır peşinden koşuyordum. Bu bilginin tüm inananları derinden etkileyeceğine inanıyorum. Nasıl desem, ‘yıkıcı’ diye tanımlanabilecek bir değişikliğe sebep olabilir.",
                CategoryId=2,
                Page= 536,
                Writer="Dan Brown",
                Production="Yabancı"
            },
            new Book
            {
                Id=4,
                Title="Da Vinci Şifresi",
                ThumbNail = "davincisifresi.jpg",
                Subject = "Dan Brown, ülkedeki birkaç usta yazardan biri. Da Vinci Şifresi üstün bir zeka tarafından kurgulanmış harika bir gerilim romanı.Entrika ve tehlikenin iç içe geçtiği okuduğum en iyi gerilim romanı. Kelime oyunları, gizemler ve bulmacalarla örülmüş akıllara durgunluk veren bir öykü.",
                CategoryId=2,
                Page=495,
                Writer="Dan Brown",
                Production="Yabancı"
            },
            new Book
            {
                Id=5,
                Title="Adalet Savaşçıları",
                ThumbNail="adaletsavascilari.jpg",
                Subject="Masal tadındaki bu fantastik kurgu,okuyucuyu bir zaman yolculuğuna çıkarır.Okuyucunun çözebileceği küçük süprizlerin gizlendiği tarihin değişik zamanlarındaki yaşanmışlıkları,aynı zaman sürecinde yaşatan bu eser,ayrıca gizemli bir aşkın romanıdır.",
                CategoryId=4,
                Page=456,
                Writer="Bahri Akkoç",
                Production="Yerli"

            }
            );
        }
    }
}
