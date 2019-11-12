using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueAPI.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AtkType = table.Column<string>(nullable: true),
                    DmgType = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    PositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Items = table.Column<string>(nullable: true),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Builds_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Top" },
                    { 2, "Jungle" },
                    { 3, "Mid" },
                    { 4, "ADC" },
                    { 5, "Support" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "AtkType", "DmgType", "Image", "Name", "PositionId" },
                values: new object[,]
                {
                    { 1, "Melee", "Attack Damage", "/images/1.png", "Aatrox", 1 },
                    { 112, "Ranged", "Ability Power", "/images/112.png", "Syndra", 3 },
                    { 121, "Ranged", "Ability Power", "/images/121.png", "Twisted Fate", 3 },
                    { 127, "Ranged", "Ability Power", "/images/127.png", "Veigar", 3 },
                    { 128, "Ranged", "Ability Power", "/images/128.png", "Velkoz", 3 },
                    { 130, "Ranged", "Ability Power", "/images/130.png", "Viktor", 3 },
                    { 136, "Ranged", "Ability Power", "/images/136.png", "Xerath", 3 },
                    { 111, "Melee", "Ability Power", "/images/111.png", "Sylas", 3 },
                    { 138, "Melee", "Attack", "/images/138.png", "Yasuo", 3 },
                    { 143, "Ranged", "Ability Power", "/images/143.png", "Ziggs", 3 },
                    { 145, "Ranged", "Ability Power", "/images/145.png", "Zoe", 3 },
                    { 15, "Ranged", "Attack Damage", "/images/15.png", "Caitlyn", 4 },
                    { 19, "Ranged", "Attack Damage", "/images/19.png", "Corki", 4 },
                    { 23, "Ranged", "Attack Damage", "/images/23.png", "Draven", 4 },
                    { 27, "Ranged", "Attack Damage", "/images/27.png", "Ezreal", 4 },
                    { 142, "Melee", "Attack Damage", "/images/142.png", "Zed", 3 },
                    { 46, "Ranged", "Attack Damage", "/images/46.png", "Jhin", 4 },
                    { 97, "Ranged", "Ability Power", "/images/97.png", "Ryze", 3 },
                    { 83, "Ranged", "Ability Power", "/images/83.png", "Orianna", 3 },
                    { 9, "Ranged", "Ability Power", "/images/9.png", "Aurrelion Sol", 3 },
                    { 10, "Ranged", "Ability Power", "/images/10.png", "Azir", 3 },
                    { 13, "Ranged", "Ability Power", "/images/13.png", "Brand", 3 },
                    { 17, "Ranged", "Ability Power", "/images/17.png", "Cassilopeia", 3 },
                    { 21, "Melee", "Ability Power", "/images/21.png", "Diana", 3 },
                    { 30, "Melee", "Ability Power", "/images/30.png", "Fizz", 3 },
                    { 88, "Melee", "Attack Damage", "/images/88.png", "Qiyana", 3 },
                    { 31, "Ranged", "Ability Power", "/images/31.png", "Galio", 3 },
                    { 52, "Melee", "Ability Power", "/images/52.png", "Kassadin", 3 },
                    { 53, "Melee", "Ability Power", "/images/53.png", "Katarina", 3 },
                    { 61, "Ranged", "Ability Power", "/images/61.png", "LeBlanc", 3 },
                    { 64, "Ranged", "Ability Power", "/images/64.png", "Lissandra", 3 },
                    { 69, "Ranged", "Ability Power", "/images/69.png", "Malzahar", 3 },
                    { 78, "Ranged", "Ability Power", "/images/78.png", "Neeko", 3 },
                    { 38, "Ranged", "Ability Power", "/images/38.png", "Heimerdinger", 3 },
                    { 47, "Ranged", "Attack Damage", "/images/47.png", "Jinx", 4 },
                    { 48, "Ranged", "Attack Damage", "/images/48.png", "Kai’Sa", 4 },
                    { 49, "Ranged", "Attack Damage", "/images/49.png", "Kalista", 4 },
                    { 75, "Ranged", "Ability Power", "/images/75.png", "Nami", 5 },
                    { 77, "Melee", "Ability Power", "/images/77.png", "Nautilus", 5 },
                    { 87, "Melee", "Attack Damage", "/images/87.png", "Pyke", 5 },
                    { 90, "Melee", "Ability Power", "/images/90.png", "Rakan", 5 },
                    { 99, "Ranged", "Attack Damage", "/images/99.png", "Senna", 5 },
                    { 100, "Melee", "Attack Damage", "/images/100.png", "Shaco", 5 },
                    { 74, "Ranged", "Ability Power", "/images/74.png", "Morgana", 5 },
                    { 106, "Ranged", "Attack Damage", "/images/106.png", "Sivir", 5 },
                    { 108, "Ranged", "Ability Power", "/images/108.png", "Sona", 5 },
                    { 109, "Ranged", "Ability Power", "/images/109.png", "Soraka", 5 },
                    { 113, "Melee", "Ability Power", "/images/113.png", "Tahm Kench", 5 },
                    { 115, "Melee", "Attack Damage", "/images/115.png", "Talon", 5 },
                    { 116, "Ranged", "Ability Power", "/images/116.png", "Teemo", 5 },
                    { 117, "Ranged", "Attack Damage", "/images/117.png", "Thresh", 5 },
                    { 107, "Melee", "Ability Power", "/images/107.png", "Skarner", 5 },
                    { 67, "Ranged", "Ability Power", "/images/67.png", "Lux", 5 },
                    { 66, "Ranged", "Ability Power", "/images/66.png", "Lulu", 5 },
                    { 63, "Melee", "Attack Damage", "/images/63.png", "Leona", 5 },
                    { 60, "Ranged", "Attack Damage", "/images/60.png", "Kog’Maw", 4 },
                    { 65, "Ranged", "Attack Damage", "/images/65.png", "Lucian", 4 },
                    { 72, "Ranged", "Attack Damage", "/images/72.png", "Miss Fortune", 4 },
                    { 118, "Ranged", "Attack Damage", "/images/118.png", "Tristana", 4 },
                    { 122, "Ranged", "Attack Damage", "/images/122.png", "Twitch", 4 },
                    { 125, "Ranged", "Attack Damage", "/images/125.png", "Varus", 4 },
                    { 126, "Ranged", "Attack Damage", "/images/126.png", "Vayne", 4 },
                    { 135, "Ranged", "Attack Damage", "/images/135.png", "Xayah", 4 },
                    { 4, "Melee", "Ability Power", "/images/4.png", "Alistar", 5 },
                    { 11, "Ranged", "Ability Power", "/images/11.png", "Bard", 5 },
                    { 12, "Ranged", "Ability Power", "/images/12.png", "Blitzcrank", 5 },
                    { 14, "Melee", "Attack Damage", "/images/14.png", "Braum", 5 },
                    { 36, "Ranged", "Attack Damage", "/images/36.png", "Graves", 5 },
                    { 42, "Ranged", "Ability Power", "/images/42.png", "Janna", 5 },
                    { 50, "Ranged", "Ability Power", "/images/50.png", "Karma", 5 },
                    { 7, "Ranged", "Ability Power", "/images/7.png", "Annie", 3 },
                    { 6, "Ranged", "Ability Power", "/images/6.png", "Anivia", 3 },
                    { 3, "Melee", "Attack Damage", "/images/3.png", "Akali", 3 },
                    { 2, "Ranged", "Ability Power", "/images/2.png", "Ahri", 3 },
                    { 86, "Melee", "Attack Damage", "/images/86.png", "Poppy", 1 },
                    { 89, "Ranged", "Attack Damage", "/images/89.png", "Quinn", 1 },
                    { 93, "Melee", "Attack Damage", "/images/93.png", "Renekton", 1 },
                    { 95, "Melee", "Attack Damage", "/images/95.png", "Riven", 1 },
                    { 96, "Ranged", "Ability Power", "/images/96.png", "Rumble", 1 },
                    { 101, "Melee", "Attack Damage", "/images/101.png", "Shen", 1 },
                    { 84, "Ranged", "Attack Damage", "/images/84.png", "Ornn", 1 },
                    { 103, "Melee", "Ability Power", "/images/103.png", "Singed", 1 },
                    { 105, "Melee", "Attack Damage", "/images/105.png", "Sion", 1 },
                    { 110, "Ranged", "Ability Power", "/images/110.png", "Swain", 1 },
                    { 120, "Melee", "Attack Damage", "/images/120.png", "Tryndamere", 1 },
                    { 124, "Ranged", "Ability Damage", "/images/124.png", "Urgot", 1 },
                    { 131, "Ranged", "Ability Power", "/images/131.png", "Vladmir", 1 },
                    { 139, "Melee", "Attack Damage", "/images/139.png", "Yorick", 1 },
                    { 104, "Ranged", "Ability Power", "/images/104.png", "Rumble", 1 },
                    { 76, "Melee", "Attack Damage", "/images/76.png", "Nasus", 1 },
                    { 73, "Melee", "Attack Damage", "/images/73.png", "Mordekaiser", 1 },
                    { 70, "Melee", "Ability Power", "/images/70.png", "Maokai", 1 },
                    { 16, "Melee", "Attack Damage", "/images/16.png", "Camille", 1 },
                    { 18, "Melee", "Ability Power", "/images/18.png", "Cho’Gath", 1 },
                    { 20, "Melee", "Attack Damage", "/images/20.png", "Darius", 1 },
                    { 29, "Melee", "Attack Damage", "/images/29.png", "Fiora", 1 },
                    { 32, "Ranged", "Attack Damage", "/images/32.png", "Gangplank", 1 },
                    { 33, "Melee", "Attack Damage", "/images/33.png", "Garen", 1 },
                    { 34, "Ranged", "Attack Damage", "/images/34.png", "Gnar", 1 },
                    { 39, "Melee", "Ability Power", "/images/39.png", "Illaoi", 1 },
                    { 40, "Melee", "Attack Damage", "/images/40.png", "Irelia", 1 },
                    { 44, "Ranged", "Attack Damage", "/images/44.png", "Jayce", 1 },
                    { 45, "Melee", "Attack Damage", "/images/45.png", "Jax", 1 },
                    { 54, "Ranged", "Ability Power", "/images/54.png", "Kayle", 1 },
                    { 56, "Ranged", "Ability Power", "/images/56.png", "Kennen", 1 },
                    { 59, "Ranged", "Attack Damage", "/images/59.png", "Kled", 1 },
                    { 68, "Melee", "Ability Power", "/images/68.png", "Malphite", 1 },
                    { 146, "Ranged", "Ability Power", "/images/146.png", "Zyra", 1 },
                    { 140, "Ranged", "Ability Power", "/images/140.png", "Yuumi", 5 },
                    { 5, "Melee", "Ability Power", "/images/5.png", "Amumu", 2 },
                    { 22, "Melee", "Ability Power", "/images/22.png", "Dr. Mundo", 2 },
                    { 91, "Melee", "Ability Power", "/images/91.png", "Rammus", 2 },
                    { 92, "Melee", "Attack Damage", "/images/92.png", "Rek’Sai", 2 },
                    { 94, "Melee", "Attack Damage", "/images/94.png", "Rengar", 2 },
                    { 98, "Melee", "Ability Power", "/images/98.png", "Sejuani", 2 },
                    { 102, "Melee", "Ability Power", "/images/102.png", "Shyvana", 2 },
                    { 114, "Melee", "Ability Power", "/images/114.png", "Taliyah", 2 },
                    { 85, "Melee", "Attack Damage", "/images/85.png", "Pantheon", 2 },
                    { 119, "Ranged", "Attack Damage", "/images/119.png", "Trundle", 2 },
                    { 129, "Melee", "Attack Damage", "/images/129.png", "Vi", 2 },
                    { 132, "Melee", "Attack Damage", "/images/132.png", "Volibear", 2 },
                    { 133, "Melee", "Attack Damage", "/images/133.png", "Warwick", 2 },
                    { 134, "Melee", "Attack Damage", "/images/134.png", "Wukong", 2 },
                    { 137, "Melee", "Ability Power", "/images/137.png", "Xin Zhao", 2 },
                    { 141, "Ranged", "Ability Power", "/images/141.png", "Zac", 2 },
                    { 123, "Melee", "Attack Damage", "/images/123.png", "Udyr", 2 },
                    { 82, "Melee", "Attack Damage", "/images/82.png", "Olaf", 2 },
                    { 81, "Melee", "Ability Power", "/images/81.png", "Nunu", 2 },
                    { 80, "Melee", "Attack Damage", "/images/80.png", "Nocturne", 2 },
                    { 24, "Melee", "Ability Power", "/images/24.png", "Ekko", 2 },
                    { 25, "Melee", "Ability Power", "/images/25.png", "Elise", 2 },
                    { 26, "Melee", "Ability Power", "/images/26.png", "Evelynn", 2 },
                    { 28, "Ranged", "Ability Power", "/images/28.png", "Fiddlesticks", 2 },
                    { 35, "Melee", "Ability Power", "/images/35.png", "Gragas", 2 },
                    { 37, "Melee", "Attack Damage", "/images/37.png", "Hecarim", 2 },
                    { 41, "Ranged", "Ability Power", "/images/41.png", "Ivern", 2 },
                    { 43, "Ranged", "Ability Power", "/images/43.png", "Jarvan IV", 2 },
                    { 51, "Ranged", "Ability Power", "/images/51.png", "Karthas", 2 },
                    { 55, "Melee", "Attack Damage", "/images/55.png", "Kayn", 2 },
                    { 57, "Melee", "Attack Damage", "/images/57.png", "Kha’Zix", 2 },
                    { 58, "Ranged", "Attack Damage", "/images/58.png", "Kindred", 2 },
                    { 62, "Melee", "Attack Damage", "/images/62.png", "Lee Sin", 2 },
                    { 71, "Melee", "Attack Damage", "/images/71.png", "Master Yi", 2 },
                    { 79, "Ranged", "Ability Power", "/images/79.png", "Nidalee", 2 },
                    { 8, "Melee", "Ability Power", "/images/8.png", "Ashe", 2 },
                    { 144, "Ranged", "Ability Power", "/images/144.png", "Zilean", 5 }
                });

            migrationBuilder.InsertData(
                table: "Builds",
                columns: new[] { "Id", "CharacterId", "Items", "Name" },
                values: new object[] { 1, 1, "Death's Dance, BloodThirster, Blade of the Ruine King, Mercurial Scimitar, Berserker Greaves, Hectech Gunblade", "Life Steal" });

            migrationBuilder.CreateIndex(
                name: "IX_Builds_CharacterId",
                table: "Builds",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PositionId",
                table: "Characters",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
