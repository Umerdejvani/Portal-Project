using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal_Project.Migrations
{
    public partial class Portal_project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoundOne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    canidateName = table.Column<string>(nullable: true),
                    fatherName = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    PhoneOne = table.Column<string>(nullable: true),
                    PhoneSec = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CNIC = table.Column<string>(nullable: true),
                    PositionAF = table.Column<string>(nullable: true),
                    DesiredSalary = table.Column<string>(nullable: true),
                    StartEmpDate = table.Column<DateTime>(nullable: false),
                    OldEmp = table.Column<string>(nullable: true),
                    HSCEdu = table.Column<string>(nullable: true),
                    FSCEdu = table.Column<string>(nullable: true),
                    BSEdu = table.Column<string>(nullable: true),
                    MSEdu = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    Qualification = table.Column<string>(nullable: true),
                    CurrentEmp = table.Column<string>(nullable: true),
                    CE_Position = table.Column<string>(nullable: true),
                    CE_Salary = table.Column<string>(nullable: true),
                    CE_Reason = table.Column<string>(nullable: true),
                    CE_StartDate = table.Column<DateTime>(nullable: false),
                    CE_MayContact = table.Column<bool>(nullable: false),
                    LastEmp = table.Column<string>(nullable: true),
                    LE_Position = table.Column<string>(nullable: true),
                    LE_Salary = table.Column<string>(nullable: true),
                    LE_Reason = table.Column<string>(nullable: true),
                    LE_StartDate = table.Column<DateTime>(nullable: false),
                    LE_EndDate = table.Column<DateTime>(nullable: false),
                    SecondLastEmp = table.Column<string>(nullable: true),
                    SLE_Position = table.Column<string>(nullable: true),
                    SLE_Salary = table.Column<string>(nullable: true),
                    SLE_Reason = table.Column<string>(nullable: true),
                    SLE_StartDate = table.Column<DateTime>(nullable: false),
                    SLE_EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoundOne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoundThree",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageAdmin = table.Column<byte[]>(nullable: true),
                    ImageCand = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoundThree", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoundOne");

            migrationBuilder.DropTable(
                name: "RoundThree");
        }
    }
}
