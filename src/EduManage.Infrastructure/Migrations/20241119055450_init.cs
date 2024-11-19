using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduManage.Infrastructure.Migrations
{
	/// <inheritdoc />
	public partial class init : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Cities",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Cities", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Departments",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Departments", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Subjects",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					GradeLavel = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Subjects", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Teachers",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					Gender = table.Column<int>(type: "int", nullable: false),
					CityId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Teachers", x => x.Id);
					table.ForeignKey(
						name: "FK_Teachers_Cities_CityId",
						column: x => x.CityId,
						principalTable: "Cities",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Students",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					Gender = table.Column<int>(type: "int", nullable: false),
					CurrentGradeLavel = table.Column<int>(type: "int", nullable: false),
					CityId = table.Column<int>(type: "int", nullable: false),
					DepartmentId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Students", x => x.Id);
					table.ForeignKey(
						name: "FK_Students_Cities_CityId",
						column: x => x.CityId,
						principalTable: "Cities",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Students_Departments_DepartmentId",
						column: x => x.DepartmentId,
						principalTable: "Departments",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Teachers_Subjects_s",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					TeacherId = table.Column<int>(type: "int", nullable: false),
					SubjectId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Teachers_Subjects_s", x => x.Id);
					table.ForeignKey(
						name: "FK_Teachers_Subjects_s_Subjects_SubjectId",
						column: x => x.SubjectId,
						principalTable: "Subjects",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Teachers_Subjects_s_Teachers_TeacherId",
						column: x => x.TeacherId,
						principalTable: "Teachers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "Students_Subjects_s",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Mark = table.Column<int>(type: "int", nullable: false),
					StudentId = table.Column<int>(type: "int", nullable: false),
					SubjectId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Students_Subjects_s", x => x.Id);
					table.ForeignKey(
						name: "FK_Students_Subjects_s_Students_StudentId",
						column: x => x.StudentId,
						principalTable: "Students",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Students_Subjects_s_Subjects_SubjectId",
						column: x => x.SubjectId,
						principalTable: "Subjects",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Students_CityId",
				table: "Students",
				column: "CityId");

			migrationBuilder.CreateIndex(
				name: "IX_Students_DepartmentId",
				table: "Students",
				column: "DepartmentId");

			migrationBuilder.CreateIndex(
				name: "IX_Students_Subjects_s_StudentId",
				table: "Students_Subjects_s",
				column: "StudentId");

			migrationBuilder.CreateIndex(
				name: "IX_Students_Subjects_s_SubjectId",
				table: "Students_Subjects_s",
				column: "SubjectId");

			migrationBuilder.CreateIndex(
				name: "IX_Teachers_CityId",
				table: "Teachers",
				column: "CityId");

			migrationBuilder.CreateIndex(
				name: "IX_Teachers_Subjects_s_SubjectId",
				table: "Teachers_Subjects_s",
				column: "SubjectId");

			migrationBuilder.CreateIndex(
				name: "IX_Teachers_Subjects_s_TeacherId",
				table: "Teachers_Subjects_s",
				column: "TeacherId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Students_Subjects_s");

			migrationBuilder.DropTable(
				name: "Teachers_Subjects_s");

			migrationBuilder.DropTable(
				name: "Students");

			migrationBuilder.DropTable(
				name: "Subjects");

			migrationBuilder.DropTable(
				name: "Teachers");

			migrationBuilder.DropTable(
				name: "Departments");

			migrationBuilder.DropTable(
				name: "Cities");
		}
	}
}
