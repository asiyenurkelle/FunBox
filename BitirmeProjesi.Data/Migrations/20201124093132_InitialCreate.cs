using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BitirmeProjesi.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ThumbNail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Page = table.Column<int>(type: "int", nullable: false),
                    Writer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Production = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activities = table.Column<bool>(type: "BİT", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ThumbNail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scenarist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Production = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activities = table.Column<bool>(type: "BİT", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    ThumbNail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scenarist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Production = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activities = table.Column<bool>(type: "BİT", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: true)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    SerieId = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                table: "Books",
                columns: new[] { "Id", "Activities", "CategoryId", "Date", "Page", "Production", "Subject", "ThumbNail", "Title", "Writer" },
                values: new object[,]
                {
                    { 1, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 192, "Yabancı", "Her birinin gizledikleri ve korktukları sırları olan on kişi, Zenci Adası’ndaki ıssız bir malikâneye davet edilirler. Ancak malikâneye giden grubu bir sürpriz beklemektedir, ev sahibi ortalarda yoktur. Geçmişlerindeki karanlık sırlardan başka hiçbir şeyleri olmayan bu insanlar adada mahsur kalmışlardır. Konuklar bir süre sonra gizledikleri sırları birbirlerine anlatırlar. Ve teker teker ölmeye başlarlar.", "onkucukzenci.jpg", "On Küçük Zenci", "Agatha Christie" },
                    { 2, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 256, "Yabancı", "Gece yarısından sonra artan şiddetli tipi yüzünden Doğu Ekspresi artık yoluna devam edemeyecek durumdadır. Yılın bu zamanlarında lüks tren tamamen doludur. Ertesi sabah yapılan kontroller sonucu tüm yolcuların sağsalim trende olduğu anlaşılır. Ancak defalarca bıçaklanarak öldürülen Amerikalı yolcunun kompartımanının kapısı içeriden kilitlidir.", "doguekspresindecinayet.jpg", "Doğu Ekspresinde Cinayet", "Agatha Christie" },
                    { 3, false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 536, "Yabancı", "Genç adam, aniden üç büyük dinin temsilcilerine döndü. “Şaşırtıcı bulacağınızı tahmin ettiğim bilimsel bir buluşum sebebiyle bugün buradayım. İnsanlık deneyimimizin en temel iki sorusuna cevap bulma ümidi ile yıllardır peşinden koşuyordum. Bu bilginin tüm inananları derinden etkileyeceğine inanıyorum. Nasıl desem, ‘yıkıcı’ diye tanımlanabilecek bir değişikliğe sebep olabilir.", "baslangic.jpg", "Başlangıç", "Dan Brown" },
                    { 4, false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 495, "Yabancı", "Dan Brown, ülkedeki birkaç usta yazardan biri. Da Vinci Şifresi üstün bir zeka tarafından kurgulanmış harika bir gerilim romanı.Entrika ve tehlikenin iç içe geçtiği okuduğum en iyi gerilim romanı. Kelime oyunları, gizemler ve bulmacalarla örülmüş akıllara durgunluk veren bir öykü.", "davincisifresi.jpg", "Da Vinci Şifresi", "Dan Brown" },
                    { 5, false, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 456, "Yerli", "Masal tadındaki bu fantastik kurgu,okuyucuyu bir zaman yolculuğuna çıkarır.Okuyucunun çözebileceği küçük süprizlerin gizlendiği tarihin değişik zamanlarındaki yaşanmışlıkları,aynı zaman sürecinde yaşatan bu eser,ayrıca gizemli bir aşkın romanıdır.", "adaletsavascilari.jpg", "Adalet Savaşçıları", "Bahri Akkoç" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Activities", "CategoryId", "Date", "Production", "Scenarist", "Subject", "ThumbNail", "Time", "Title" },
                values: new object[,]
                {
                    { 2, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yabancı", "Mario Puzo", "Baba, 40’lar ve 50’lerin Amerika’sında, bir İtalyan mafya ailesinin destansı öyküsünü konu alıyor. Don Corleone’nin kızı Connie’nin düğününde, ailenin en küçük oğlu ve bir savaş gazisi olan Michael babasıyla barışır. Bir suikast girişimi, Don’u artık işleri yönetemeyecek duruma düşürünce, ailenin başına Michael ve ağabeyi Sonny geçer.", "thegodfather.jpg", "2 saat 58 dakika", "The Godfather" },
                    { 1, false, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yerli", "Umur Bugay", "Öğrencilik hayatları haylazlık ve tembellik üzerine kurulu olan bir sınıf dolusu matrak öğrencinin, Özel Çamlıca Lisesi’nde yaşadığı yer yer eğlenceli, yer yer de dokunaklı öyküleri anlatan film, Hababam Sınıfı serisinin ilk filmidir", "hababamsinifi.jpg", "1 saat 30 dakika", "Hababam Sınıfı" },
                    { 3, false, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yabancı", "Randall Wallace", "Cesuryürek'te, William Wallace yaşanan büyük acılar sonrası yeniden memleketi olan İskoçya’ya döner. Onun asıl amacı çiftçilik yaparak sakin bir hayat sürmektir. Çocukluk aşkıyla karşılaştığında bunun onu dipsiz bir uçuruma iteceğinin farkında değildir.", "braveheart.jpg", "3 saat 2 dakika", "Braveheart" },
                    { 4, false, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yerli", "Yavuz Turgul", "Eşkiya, hapse düşmesine neden olan arkadaşının peşine düşen bir adamın hikayesini anlatıyor. 35 yıl önce Cudi dağlarında bir grup eşkiya yakalandı ve hapse atıldı. Yıllar içinde kimi hastalıktan, kimi hesaplaşma sonucu öldü. Biri hariç... 35 yıl sonra Hapisten çıkınca Baran’ ın ilk işi köyüne dönmek olur.", "eskiya.jpg", "2 saat 8 dakika", "Eşkiya" }
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Activities", "CategoryId", "Date", "Production", "Scenarist", "Subject", "ThumbNail", "Time", "Title" },
                values: new object[,]
                {
                    { 6, false, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yabancı", "Howard Fast", "Trakyalılar çoğunlukla Trakya topraklarını yağmalayan Getae’ye karşı bir ayaklanma düzenleyerek Roma lejyonlarında yardımcı olarak görev yapacakları Claudius Glaber tarafından ikna edilmeye başlanmıştır. Bununla birlikte, Glaber, anlaşma konusunda ısrar ettikten sonra Getae’ten dikkatini Küçük Asya’daki Mithridates saldırısına çekmeyi başarır.", "spartacus.jpg", "42 dakika", "Spartacus" },
                    { 3, false, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yabancı", "Lauren Schmidt Hissrich", "Fantastik bir dizi olan The Witcher’da, çok uzun yıllardır barış içerisinde yaşayan insanlar, cüceler ve elfler artık savaş halindedir. Ana karakterimiz The Witcher lakaplı Geralt of Rivia ise acımasız bir suikastçıdır. Kendisi durumun farkında olmasa da aslında kendisine vaadedilen bir kız çocuğu bu dünya düzenini değiştirecektir.", "thewitcher.jpg", "1 saat", "The Witcher" },
                    { 4, false, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yabancı", "Blake Neely", "kitapçıda çalışan Joe ve o kitapçıya müşteri olarak gelen Beck’in hikayesini izleyiciye aktarmaktadır. Joe, Beck’e gördüğü andan itibaren aşık durumdadır ve onu korumak için ne gerekiyorsa yapmaktadır. Joe’nin Beck’e karşı takıntılı tavırlar göstermesi Beck’in yakın arkadaşı Peach’in dikkatini çekse de Joe’ye engel olmak mümkün değildir. Yaptığı her takıntılı davranışı Beck’e aşık olduğu için yaptığını düşünen Joe, aslında tam bir saplantı yaşamaktadır.", "you.jpg", "45 dakika", "You" },
                    { 1, false, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yabancı", "Steven Knigt", "Peaky Blinders, İngiltere'nin Birmingham şehrinde çetelerin birbiriyle yaşadığı olayları izleyiciye aktarmaktadır. Çete için her şey tıkırında giderken son bir soygunda hata yapılır ve çetenin başına bela olacak bir müfettiş görevlendirilir.", "peakyblinders.jpg", "58 dakika", "Peaky Blinders" },
                    { 2, false, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yabancı", "Andrew Baldwin", "11 yaşında feci şekilde katledilen bir çocuğun cesedi parkta bulunur. Etraftaki görgü tanıkları ve cesedin üzerindeki bulgular, şehirde yaşayan saygın bir iş adamını işaret etmektedir. Bu kişi ise koçluk ve  İngilizce öğretmenliği yapan, aynı zamanda iyi bir eş ve kız babası olan Terry Maitland’dır.", "theoutsider.jpg", "1 saat", "The Outsider" },
                    { 5, false, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yabancı", "Matt Duffer", " Winona Ryder, David Harbour, Cara Buono'yu başrollerinde buluşturan dizide, kaybolan genç çocuk ve onu bulmaya çalışan ailenin yaşadıkları anlatılmaktadır.", "strangerthings.jpg", "56 dakika", "Stranger Things" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
