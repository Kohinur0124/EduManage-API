using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduManage.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seeddata1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8529), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8532), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8534), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8539), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8543), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8548), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8597), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8599), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 11, 20, 10, 44, 31, 945, DateTimeKind.Local).AddTicks(8602) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3154), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3169), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3172), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3174), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3175), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3178), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3179), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3181), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3183), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3185), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3229), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3235), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3237), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "CreatedDate" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 41, 3, 748, DateTimeKind.Local).AddTicks(3239), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
