using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BitirmeProjesi.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    Picture = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    ThumbNail = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Page = table.Column<int>(nullable: false),
                    Writer = table.Column<string>(nullable: true),
                    Production = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    NVARCHARMAX = table.Column<string>(name: "NVARCHAR(MAX)", nullable: false),
                    ThumbNail = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Time = table.Column<int>(nullable: false),
                    Scenarist = table.Column<string>(nullable: false),
                    Production = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ThumbNail = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Time = table.Column<int>(nullable: false),
                    Scenarist = table.Column<string>(nullable: false),
                    Production = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Subject = table.Column<string>(maxLength: 500, nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    SerieId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Comments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Comments_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Comments_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Polisiye" },
                    { 2, "Roman" },
                    { 3, "Hikaye" },
                    { 4, "Bilim Kurgu" },
                    { 5, "Aksiyon" },
                    { 6, "Macera" },
                    { 7, "Psikoloji" },
                    { 8, "Siyaset" },
                    { 9, "Tarih" },
                    { 10, "Komedi" },
                    { 11, "Dram" },
                    { 12, "Romantik" },
                    { 13, "Korku" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "Picture", "UserName" },
                values: new object[] { 1, "asiyekelle7@gmail.com", "Asiye Nur", "Kelle", new byte[] { 32, 102, 49, 98, 51, 99, 49, 98, 52, 99, 48, 51, 51, 53, 101, 54, 57, 48, 54, 101, 101, 48, 100, 99, 102, 57, 54, 100, 48, 98, 54, 49, 55 }, "default.jpg", "asiyenurkelle" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Page", "Production", "Subject", "ThumbNail", "Title", "Writer" },
                values: new object[,]
                {
                    { 1, 1, 192, "Yabancı", "Her birinin gizledikleri ve korktukları sırları olan on kişi, Zenci Adası’ndaki ıssız bir malikâneye davet edilirler. Ancak malikâneye giden grubu bir sürpriz beklemektedir, ev sahibi ortalarda yoktur. Geçmişlerindeki karanlık sırlardan başka hiçbir şeyleri olmayan bu insanlar adada mahsur kalmışlardır. Konuklar bir süre sonra gizledikleri sırları birbirlerine anlatırlar. Ve teker teker ölmeye başlarlar.", "default.jpg", "On Küçük Zenci", "Agatha Christie" },
                    { 2, 1, 256, "Yabancı", "Gece yarısından sonra artan şiddetli tipi yüzünden Doğu Ekspresi artık yoluna devam edemeyecek durumdadır. Yılın bu zamanlarında lüks tren tamamen doludur. Ertesi sabah yapılan kontroller sonucu tüm yolcuların sağsalim trende olduğu anlaşılır. Ancak defalarca bıçaklanarak öldürülen Amerikalı yolcunun kompartımanının kapısı içeriden kilitlidir.", "default.jpg", "Doğu Ekspresinde Cinayet", "Agatha Christie" },
                    { 3, 2, 536, "Yabancı", "Genç adam, aniden üç büyük dinin temsilcilerine döndü. “Şaşırtıcı bulacağınızı tahmin ettiğim bilimsel bir buluşum sebebiyle bugün buradayım. İnsanlık deneyimimizin en temel iki sorusuna cevap bulma ümidi ile yıllardır peşinden koşuyordum. Bu bilginin tüm inananları derinden etkileyeceğine inanıyorum. Nasıl desem, ‘yıkıcı’ diye tanımlanabilecek bir değişikliğe sebep olabilir.", "default.jpg", "Başlangıç", "Dan Brown" },
                    { 4, 2, 495, "Yabancı", "Dan Brown, ülkedeki birkaç usta yazardan biri. Da Vinci Şifresi üstün bir zeka tarafından kurgulanmış harika bir gerilim romanı.Entrika ve tehlikenin iç içe geçtiği okuduğum en iyi gerilim romanı. Kelime oyunları, gizemler ve bulmacalarla örülmüş akıllara durgunluk veren bir öykü.", "default.jpg", "Da Vinci Şifresi", "Dan Brown" },
                    { 5, 4, 456, "Yerli", "Masal tadındaki bu fantastik kurgu,okuyucuyu bir zaman yolculuğuna çıkarır.Okuyucunun çözebileceği küçük süprizlerin gizlendiği tarihin değişik zamanlarındaki yaşanmışlıkları,aynı zaman sürecinde yaşatan bu eser,ayrıca gizemli bir aşkın romanıdır.", "default.jpg", "Adalet Savaşçıları", "Bahri Akkoç" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "Production", "Scenarist", "NVARCHAR(MAX)", "ThumbNail", "Time", "Title" },
                values: new object[,]
                {
                    { 2, 1, "Yabancı", "Mario Puzo", "Baba, 40’lar ve 50’lerin Amerika’sında, bir İtalyan mafya ailesinin destansı öyküsünü konu alıyor. Don Corleone’nin kızı Connie’nin düğününde, ailenin en küçük oğlu ve bir savaş gazisi olan Michael babasıyla barışır. Bir suikast girişimi, Don’u artık işleri yönetemeyecek duruma düşürünce, ailenin başına Michael ve ağabeyi Sonny geçer.", "default.jpg", 178, "The Godfather" },
                    { 1, 10, "Yerli", "Umur Bugay", "Öğrencilik hayatları haylazlık ve tembellik üzerine kurulu olan bir sınıf dolusu matrak öğrencinin, Özel Çamlıca Lisesi’nde yaşadığı yer yer eğlenceli, yer yer de dokunaklı öyküleri anlatan film, Hababam Sınıfı serisinin ilk filmidir", "default.jpg", 90, "Hababam Sınıfı" },
                    { 3, 11, "Yabancı", "Randall Wallace", "Cesuryürek'te, William Wallace yaşanan büyük acılar sonrası yeniden memleketi olan İskoçya’ya döner. Onun asıl amacı çiftçilik yaparak sakin bir hayat sürmektir. Çocukluk aşkıyla karşılaştığında bunun onu dipsiz bir uçuruma iteceğinin farkında değildir.", "default.jpg", 182, "Braveheart" },
                    { 4, 11, "Yerli", "Yavuz Turgul", "Eşkiya, hapse düşmesine neden olan arkadaşının peşine düşen bir adamın hikayesini anlatıyor. 35 yıl önce Cudi dağlarında bir grup eşkiya yakalandı ve hapse atıldı. Yıllar içinde kimi hastalıktan, kimi hesaplaşma sonucu öldü. Biri hariç... 35 yıl sonra Hapisten çıkınca Baran’ ın ilk işi köyüne dönmek olur.", "default.jpg", 128, "Eşkiya" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "CategoryId", "Production", "Scenarist", "Subject", "ThumbNail", "Time", "Title" },
                values: new object[,]
                {
                    { 6, 4, "Yabancı", "Howard Fast", "Trakyalılar çoğunlukla Trakya topraklarını yağmalayan Getae’ye karşı bir ayaklanma düzenleyerek Roma lejyonlarında yardımcı olarak görev yapacakları Claudius Glaber tarafından ikna edilmeye başlanmıştır. Bununla birlikte, Glaber, anlaşma konusunda ısrar ettikten sonra Getae’ten dikkatini Küçük Asya’daki Mithridates saldırısına çekmeyi başarır.", "default.jpg", 42, "Spartacus" },
                    { 3, 6, "Yabancı", "Lauren Schmidt Hissrich", "Fantastik bir dizi olan The Witcher’da, çok uzun yıllardır barış içerisinde yaşayan insanlar, cüceler ve elfler artık savaş halindedir. Ana karakterimiz The Witcher lakaplı Geralt of Rivia ise acımasız bir suikastçıdır. Kendisi durumun farkında olmasa da aslında kendisine vaadedilen bir kız çocuğu bu dünya düzenini değiştirecektir.", "default.jpg", 60, "The Witcher" },
                    { 4, 6, "Yabancı", "Blake Neely", "kitapçıda çalışan Joe ve o kitapçıya müşteri olarak gelen Beck’in hikayesini izleyiciye aktarmaktadır. Joe, Beck’e gördüğü andan itibaren aşık durumdadır ve onu korumak için ne gerekiyorsa yapmaktadır. Joe’nin Beck’e karşı takıntılı tavırlar göstermesi Beck’in yakın arkadaşı Peach’in dikkatini çekse de Joe’ye engel olmak mümkün değildir. Yaptığı her takıntılı davranışı Beck’e aşık olduğu için yaptığını düşünen Joe, aslında tam bir saplantı yaşamaktadır.", "default.jpg", 45, "You" },
                    { 1, 11, "Yabancı", "Steven Knigt", "Peaky Blinders, İngiltere'nin Birmingham şehrinde çetelerin birbiriyle yaşadığı olayları izleyiciye aktarmaktadır. Çete için her şey tıkırında giderken son bir soygunda hata yapılır ve çetenin başına bela olacak bir müfettiş görevlendirilir.", "default.jpg", 58, "Peaky Blinders" },
                    { 2, 11, "Yabancı", "Andrew Baldwin", "11 yaşında feci şekilde katledilen bir çocuğun cesedi parkta bulunur. Etraftaki görgü tanıkları ve cesedin üzerindeki bulgular, şehirde yaşayan saygın bir iş adamını işaret etmektedir. Bu kişi ise koçluk ve  İngilizce öğretmenliği yapan, aynı zamanda iyi bir eş ve kız babası olan Terry Maitland’dır.", "default.jpg", 60, "The Outsider" },
                    { 5, 13, "Yabancı", "Matt Duffer", " Winona Ryder, David Harbour, Cara Buono'yu başrollerinde buluşturan dizide, kaybolan genç çocuk ve onu bulmaya çalışan ailenin yaşadıkları anlatılmaktadır.", "default.jpg", 56, "Stranger Things" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BookId", "CategoryId", "MovieId", "SerieId", "Subject", "Title" },
                values: new object[] { 1, 0, 0, 2, 0, "Bu film diğer filmlere nazaran oyuncular daha iyiydi,film akıcıydı.", "Film oyuncuları hakkında" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookId",
                table: "Comments",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CategoryId",
                table: "Comments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MovieId",
                table: "Comments",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SerieId",
                table: "Comments",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_CategoryId",
                table: "Series",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
