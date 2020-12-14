using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppControllers",
                columns: table => new
                {
                    Controller = table.Column<string>(nullable: false),
                    Action = table.Column<string>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Licensed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppControllers", x => new { x.Controller, x.Action });
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleControllerGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRole = table.Column<Guid>(nullable: false),
                    Controller = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleControllerGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleControllers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Controller = table.Column<string>(nullable: false),
                    Action = table.Column<string>(nullable: false),
                    AppUser = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleControllers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 200, nullable: false),
                    LastName = table.Column<string>(maxLength: 200, nullable: false),
                    Dob = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: true),
                    MenuName = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IconClass = table.Column<string>(maxLength: 50, nullable: true),
                    Url = table.Column<string>(maxLength: 200, nullable: true),
                    MenuOrder = table.Column<int>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                });

            migrationBuilder.InsertData(
                table: "AppControllers",
                columns: new[] { "Controller", "Action", "Area", "Description", "Licensed" },
                values: new object[,]
                {
                    { "User", "Index", null, "Quản lý User", true },
                    { "Home", "Index", null, "Trang Chủ", true }
                });

            migrationBuilder.InsertData(
                table: "AppRoleControllerGroups",
                columns: new[] { "Id", "Action", "Controller", "Description", "IdRole" },
                values: new object[,]
                {
                    { 4, "DETAIL", "User", null, new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee") },
                    { 3, "EDIT", "User", null, new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee") },
                    { 1, "Index", "User", null, new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee") },
                    { 2, "Delete", "User", null, new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee") }
                });

            migrationBuilder.InsertData(
                table: "AppRoleControllers",
                columns: new[] { "Id", "Action", "AppUser", "Controller", "Description" },
                values: new object[] { 1, "GetAllPaging", "admin", "Users", null });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"), "9b8cb4f6-10d3-43bb-8f0b-62a74c6ebc94", "Nhân Sự", "Nhansu", "Cấp 2" },
                    { new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"), "f32e72e3-b49e-495c-9f67-ac8d3345e070", "Mua hàng", "MuaHang", "Cấp 2" },
                    { new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"), "f2efd9c3-d181-43f0-ac51-43af15d28f77", "BanHang", "BanHang", "Cấp 2" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "d2ec85ae-a05d-434b-aa65-64f1aa226066", "Administrator role", "Administrator", "Cấp 1" },
                    { new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"), "b94df6c3-a2b9-45e4-bd99-796f9e67d389", "Kho", "Kho", "Cấp 2" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "91ba7460-81e4-49c6-8b38-dc711084e760", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Nguyễn", "Admin", false, null, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAECnXqPWZexktLB2ufN+eBJ/wifdVflsGaZivPLH+/I73aDRCee+V+HdlG1CzO2r3GQ==", null, false, "", false, "admin" },
                    { new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"), 0, "629d77d5-4bdb-430c-83c9-bc971b4d6059", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "it@gmail.com", true, "Nguyễn", "It", false, null, "it@gmail.com", "it", "AQAAAAEAACcQAAAAEH66KfV0frG4uPJVCGa6dLmWRqQHa+748k6BtcXOJy1x6SGYAb1V7X//miv96Njlog==", null, false, "", false, "it" },
                    { new Guid("171f3098-762c-4b02-85c5-a687f6601de4"), 0, "c8940b31-ab2b-4d7f-ae3b-87ea1a117ee7", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "kho@gmail.com", true, "Nguyễn", "Kho", false, null, "kho@gmail.com", "kho", "AQAAAAEAACcQAAAAEH+a98j079wN2CL8l6vuiy3TXNmYRoUwv25zh5wnq5da5iq1rzyIs9319shipYX7yg==", null, false, "", false, "kho" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "Description", "IconClass", "IsVisible", "MenuName", "MenuOrder", "ParentID", "Url" },
                values: new object[,]
                {
                    { 4, null, null, true, "Thành Phẩm", 1, 2, "/" },
                    { 1, null, null, true, "Trang Chính", 1, null, "/" },
                    { 2, null, null, true, "Kho", 1, null, "/" },
                    { 3, null, null, true, "Nguyên Liệu", 1, 2, "/" },
                    { 5, null, null, true, "Kinh Doanh", 1, null, "/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppControllers");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoleControllerGroups");

            migrationBuilder.DropTable(
                name: "AppRoleControllers");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
