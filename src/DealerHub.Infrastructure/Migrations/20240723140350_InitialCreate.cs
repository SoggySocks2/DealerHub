using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sysDealer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address_AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address_AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address_AddressLine3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address_PostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ContactInfo_HomeTelNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ContactInfo_MobileTelNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ContactInfo_EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sysDealer", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sysDealer");
        }
    }
}
