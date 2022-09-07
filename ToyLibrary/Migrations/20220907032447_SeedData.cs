using Microsoft.EntityFrameworkCore.Migrations;

namespace ToyLibrary.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Toys",
                type: "varchar(40) CHARACTER SET utf8mb4",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Toys",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Toys",
                columns: new[] { "ToyId", "Description", "Name", "UserAgeMaximum", "UserAgeMinimum" },
                values: new object[,]
                {
                    { 1, "Shape-sorting cube with 6 rubbery shapes tethered to its corners", "Oombee Cube Sorter", 2, 1 },
                    { 2, "Colorful transparent pipes that easily stick to the bathtub walls to build all kinds of fascinating waterfall chains.", "Boon Pipes Building Bath Toy", 3, 1 },
                    { 3, "3D magnetic building tiles in bright colors and classic geometric shapes.", "Magna Tiles", 17, 1 },
                    { 4, "60 Snap-Together parts consisting of electrical components that can be used to make circuits and learn about electricity.", "Elenco Snap Circuits Classic", 17, 8 },
                    { 5, "Paddleboard designed for kids ages 5 and up or up to 130 lb. Great stability and tracking in both surf and flat water. Constructed of UV-protected High-Density Polyethylene", "Lifetime Hooligan Youth Paddleboard", 17, 5 },
                    { 6, "A board game that incorporates a smartphone app and virtual reality. Feels like a modern update to Clue for the tech-savvy teen. Players are presented with an unsolved murder or heist, and they determine who committed the crime, which weapons were used, and why.", "Chronicles of Crime", 17, 16 },
                    { 7, "Soft and cuddly 12-inch gender neutral baby doll. An ideal first doll that will encourage little ones to role play, nurture and care. ", "Wee Baby Stella", 4, 1 },
                    { 8, "Wood and plastic Ikea train train set. Children can load and unload the cars as they like since the upper parts are detachable.", "Lillabo 3 Piece Train Set", 5, 3 },
                    { 9, "Players hike along the trail, collecting rocks, acorns and leaves; taking pictures; and encountering wildlife to gain bonuses. Game explores national parks across the US.", "Trails: A Parks Game", 17, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "ToyId",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Toys",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40) CHARACTER SET utf8mb4",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Toys",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");
        }
    }
}
