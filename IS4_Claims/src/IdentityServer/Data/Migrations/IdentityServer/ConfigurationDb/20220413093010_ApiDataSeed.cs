using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class ApiDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApiResources",
                columns: new[] { "Id", "AllowedAccessTokenSigningAlgorithms", "Created", "Description", "DisplayName", "Enabled", "LastAccessed", "Name", "NonEditable", "ShowInDiscoveryDocument", "Updated" },
                values: new object[] { 1, null, new DateTime(2022, 4, 13, 9, 30, 8, 422, DateTimeKind.Utc).AddTicks(4857), null, "My Web API", true, null, "web_api", false, true, null });

            migrationBuilder.InsertData(
                table: "ApiScopes",
                columns: new[] { "Id", "Description", "DisplayName", "Emphasize", "Enabled", "Name", "Required", "ShowInDiscoveryDocument" },
                values: new object[,]
                {
                    { 1, null, "Web Api Read", false, true, "web_api_read", false, true },
                    { 2, null, "Web Api write", false, true, "web_api_write", false, true }
                });

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 13, 9, 30, 8, 426, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 13, 9, 30, 8, 431, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 13, 9, 30, 8, 431, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 13, 9, 30, 8, 425, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 13, 9, 30, 8, 426, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 13, 9, 30, 8, 426, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 4, 13, 9, 30, 8, 426, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.InsertData(
                table: "ApiResourceScopes",
                columns: new[] { "Id", "ApiResourceId", "Scope" },
                values: new object[] { 11, 1, "web_api_read" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApiResourceScopes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ApiScopes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApiScopes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 5, 9, 4, 32, 135, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 5, 9, 4, 32, 143, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 5, 9, 4, 32, 143, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 5, 9, 4, 32, 131, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 5, 9, 4, 32, 131, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 5, 9, 4, 32, 131, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 4, 5, 9, 4, 32, 132, DateTimeKind.Utc).AddTicks(909));
        }
    }
}
