using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseModels.Migrations
{
    /// <inheritdoc />
    public partial class Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "curators",
                columns: table => new
                {
                    curators_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    curators_name = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    curators_surname = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curators", x => x.curators_id);
                    table.CheckConstraint("CK_curators_name_not_empty", "LEN(TRIM(curators_name)) > 0");
                    table.CheckConstraint("CK_curators_surname_not_empty", "LEN(TRIM(curators_surname)) > 0");
                });

            migrationBuilder.CreateTable(
                name: "faculties",
                columns: table => new
                {
                    faculty_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    faculty_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculties", x => x.faculty_id);
                    table.CheckConstraint("CK_faculties_name_not_empty", "LEN(TRIM(faculty_name)) > 0");
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    student_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_name = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    student_rating = table.Column<int>(type: "int", nullable: false),
                    student_surname = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.student_id);
                    table.CheckConstraint("CK_students_name_not_empty", "LEN(TRIM(student_name)) > 0");
                    table.CheckConstraint("CK_students_rating_range", "[student_rating] BETWEEN 0 AND 5");
                    table.CheckConstraint("CK_students_surname_not_empty", "LEN(TRIM(student_surname)) > 0");
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    subject_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.subject_id);
                    table.CheckConstraint("CK_subjects_name_not_empty", "LEN(TRIM(subject_name)) > 0");
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    teacher_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsProfessor = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    teacher_name = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    teacher_salary = table.Column<decimal>(type: "money", nullable: false),
                    teacher_surname = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.teacher_id);
                    table.CheckConstraint("CK_teachers_name_not_empty", "LEN(TRIM(teacher_name)) > 0");
                    table.CheckConstraint("CK_teachers_salary_positive", "[teacher_salary] > 0");
                    table.CheckConstraint("CK_teachers_surname_not_empty", "LEN(TRIM(teacher_surname)) > 0");
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    department_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    department_building = table.Column<int>(type: "int", nullable: false),
                    department_financing = table.Column<decimal>(type: "money", nullable: false, defaultValue: 0m),
                    department_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    faculty_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.department_id);
                    table.CheckConstraint("CK_department_building_range", "[department_building] >= 1 AND [department_building] <= 5");
                    table.CheckConstraint("CK_department_financing_positive", "[department_financing] >= 0");
                    table.CheckConstraint("CK_department_name_not_empty", "LEN(TRIM(department_name)) > 0");
                    table.ForeignKey(
                        name: "FK_departments_faculties_faculty_id",
                        column: x => x.faculty_id,
                        principalTable: "faculties",
                        principalColumn: "faculty_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lectures",
                columns: table => new
                {
                    lecture_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lecture_date = table.Column<DateTime>(type: "date", nullable: false),
                    subject_id = table.Column<int>(type: "int", nullable: false),
                    teacher_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectures", x => x.lecture_id);
                    table.CheckConstraint("CK_lectures_date_not_future", "[lecture_date] <= GETDATE()");
                    table.ForeignKey(
                        name: "FK_lectures_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "subject_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lectures_teachers_teacher_id",
                        column: x => x.teacher_id,
                        principalTable: "teachers",
                        principalColumn: "teacher_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    group_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    group_year = table.Column<int>(type: "int", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.group_id);
                    table.CheckConstraint("CK_groups_name_not_empty", "LEN(TRIM(group_name)) > 0");
                    table.CheckConstraint("CK_groups_year_range", "[group_year] BETWEEN 1 AND 5");
                    table.ForeignKey(
                        name: "FK_groups_departments_department_id",
                        column: x => x.department_id,
                        principalTable: "departments",
                        principalColumn: "department_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "group_lectures",
                columns: table => new
                {
                    group_lectures_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_lectures_group_id = table.Column<int>(type: "int", nullable: false),
                    group_lectures_lecture_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_lectures", x => x.group_lectures_id);
                    table.ForeignKey(
                        name: "FK_group_lectures_groups_group_id",
                        column: x => x.group_lectures_group_id,
                        principalTable: "groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_group_lectures_lectures_lecture_id",
                        column: x => x.group_lectures_lecture_id,
                        principalTable: "lectures",
                        principalColumn: "lecture_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "group_students",
                columns: table => new
                {
                    group_student_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_student_group_id = table.Column<int>(type: "int", nullable: false),
                    group_student_student_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_group_students", x => x.group_student_id);
                    table.ForeignKey(
                        name: "FK_group_students_groups_group_id",
                        column: x => x.group_student_group_id,
                        principalTable: "groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_group_students_students_student_id",
                        column: x => x.group_student_student_id,
                        principalTable: "students",
                        principalColumn: "student_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "groups_curators",
                columns: table => new
                {
                    group_curator_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_curator_group_id = table.Column<int>(type: "int", nullable: false),
                    group_curator_curator_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups_curators", x => x.group_curator_id);
                    table.ForeignKey(
                        name: "FK_groups_curators_curator_id",
                        column: x => x.group_curator_curator_id,
                        principalTable: "curators",
                        principalColumn: "curators_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_groups_curators_group_id",
                        column: x => x.group_curator_group_id,
                        principalTable: "groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_departments_department_name",
                table: "departments",
                column: "department_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_departments_faculty_id",
                table: "departments",
                column: "faculty_id");

            migrationBuilder.CreateIndex(
                name: "IX_faculties_faculty_name",
                table: "faculties",
                column: "faculty_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_group_lectures_group_lectures_group_id",
                table: "group_lectures",
                column: "group_lectures_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_lectures_group_lectures_lecture_id",
                table: "group_lectures",
                column: "group_lectures_lecture_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_students_group_student_group_id",
                table: "group_students",
                column: "group_student_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_group_students_group_student_student_id",
                table: "group_students",
                column: "group_student_student_id");

            migrationBuilder.CreateIndex(
                name: "IX_groups_department_id",
                table: "groups",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_groups_group_name",
                table: "groups",
                column: "group_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_groups_curators_group_curator_curator_id",
                table: "groups_curators",
                column: "group_curator_curator_id");

            migrationBuilder.CreateIndex(
                name: "IX_groups_curators_group_curator_group_id",
                table: "groups_curators",
                column: "group_curator_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_lectures_subject_id",
                table: "lectures",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_lectures_teacher_id",
                table: "lectures",
                column: "teacher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "group_lectures");

            migrationBuilder.DropTable(
                name: "group_students");

            migrationBuilder.DropTable(
                name: "groups_curators");

            migrationBuilder.DropTable(
                name: "lectures");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "curators");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "faculties");
        }
    }
}
