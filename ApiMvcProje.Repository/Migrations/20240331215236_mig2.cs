using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMvcProje.Repository.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "id",
                keyValue: 2,
                column: "ProductId",
                value: 2);

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "id", "Height", "ProductId", "Width", "color" },
                values: new object[] { 1, 100, 1, 200, "Kırmızı" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 52, 36, 49, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 52, 36, 49, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 52, 36, 49, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 52, 36, 49, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 52, 36, 49, DateTimeKind.Local).AddTicks(2850));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "id",
                keyValue: 2,
                column: "ProductId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 44, 51, 161, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 44, 51, 161, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 44, 51, 161, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 44, 51, 161, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 0, 44, 51, 161, DateTimeKind.Local).AddTicks(7525));
        }
    }
}
