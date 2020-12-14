using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiver.Data.Migrations
{
    public partial class TableMenuFixData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "2b470e45-ff77-4ec7-90bb-22fb1bfcaf13");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "41cecef7-2e52-4bf3-a232-3eeed7871254");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "5a4da9a5-83ed-4846-a7fe-77cb8b5f1999");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "d5ac458c-9b86-43e4-ab82-a67f9f082f21");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "aac0753c-2f4a-41b0-a23c-38cfd96abd25");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9282e95-3415-4e05-a942-d6ae89e5f33f", "AQAAAAEAACcQAAAAEPy00itHZFGtr1l1lsmUB4NetYy4Wbw9ekb98ibgHDZJIlaSOAObk4FuaT14m+JCKQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d90f2af-3e1d-461e-a96d-b642d6fcd723", "AQAAAAEAACcQAAAAEKkCnPozPj9VrLLtIlIwX/M84Kc1D8AbsjobZy84+kkbc8j0xj0vdEgX0CMWFdWL6w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8ba170e-4d51-4113-b82f-1a7a8f1e43d8", "AQAAAAEAACcQAAAAEB/qd4GQjUrv/PJi3VR2OnDb/IY/2W7AQggZqND19E19yY0wKGqKRRlH7FAxWnTllQ==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "ParentID",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "ParentID",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "ParentID",
                value: -1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                column: "ConcurrencyStamp",
                value: "b94df6c3-a2b9-45e4-bd99-796f9e67d389");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                column: "ConcurrencyStamp",
                value: "f2efd9c3-d181-43f0-ac51-43af15d28f77");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                column: "ConcurrencyStamp",
                value: "9b8cb4f6-10d3-43bb-8f0b-62a74c6ebc94");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                column: "ConcurrencyStamp",
                value: "f32e72e3-b49e-495c-9f67-ac8d3345e070");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d2ec85ae-a05d-434b-aa65-64f1aa226066");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8940b31-ab2b-4d7f-ae3b-87ea1a117ee7", "AQAAAAEAACcQAAAAEH+a98j079wN2CL8l6vuiy3TXNmYRoUwv25zh5wnq5da5iq1rzyIs9319shipYX7yg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91ba7460-81e4-49c6-8b38-dc711084e760", "AQAAAAEAACcQAAAAECnXqPWZexktLB2ufN+eBJ/wifdVflsGaZivPLH+/I73aDRCee+V+HdlG1CzO2r3GQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "629d77d5-4bdb-430c-83c9-bc971b4d6059", "AQAAAAEAACcQAAAAEH66KfV0frG4uPJVCGa6dLmWRqQHa+748k6BtcXOJy1x6SGYAb1V7X//miv96Njlog==" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "ParentID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "ParentID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "ParentID",
                value: null);
        }
    }
}
