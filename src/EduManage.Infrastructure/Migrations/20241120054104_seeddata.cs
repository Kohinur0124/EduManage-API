using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduManage.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LastUpdatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Toshkent shahri" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Toshkent viloyati" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Buxoro voloyati" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Fargona viloyati" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LastUpdatedDate", "Name" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Komputer injinering fakulteti" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedDate", "GradeLavel", "IsDeleted", "LastUpdatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, null, "Web dasturlash" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, null, "Multimedia Dasturlash" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, null, "Kompyuter ko'rish" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, null, "SMM" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, false, null, "3D texnalogiya" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CityId", "CreatedDate", "CurrentGradeLavel", "DepartmentId", "Gender", "IsDeleted", "LastUpdatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3154), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 1, false, null, "Sevinch Xayriddinobva" },
                    { 2, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3169), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 1, false, null, "Sabira Qurbonbekova" },
                    { 3, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3172), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 0, false, null, "Sanjar Toirjonov" },
                    { 4, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3174), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 0, false, null, "Fayzullo Togonboyev" },
                    { 5, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3175), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 0, false, null, "Quvonchbek Toychiyev" },
                    { 6, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3178), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 0, false, null, "Azizbek Shodmonov" },
                    { 7, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3179), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 0, false, null, "Alisher Amrullayev" },
                    { 8, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3181), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 0, false, null, "Jasurbek Abdullayev" },
                    { 9, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3183), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 1, false, null, "Jumagul Muhammadjonova" },
                    { 10, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3185), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, 1, false, null, "Shahnoza Sherqoziyeva" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "BirthDate", "CityId", "CreatedDate", "Gender", "IsDeleted", "LastUpdatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3229), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, "Sadikov Rustamjon" },
                    { 2, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3235), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, "Nematov Abdugani" },
                    { 3, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3237), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "Artikova Muazzam" },
                    { 4, new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3239), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "Abidova Shahnoza" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
