using Microsoft.EntityFrameworkCore.Migrations;

namespace MobilePhoneCatalog.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Weitht = table.Column<double>(nullable: false),
                    ScreenSize = table.Column<double>(nullable: false),
                    ScreenRezolution = table.Column<string>(nullable: true),
                    CpuModel = table.Column<string>(nullable: true),
                    Storage = table.Column<int>(nullable: false),
                    OperationSystem = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    PictureAndVideo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
