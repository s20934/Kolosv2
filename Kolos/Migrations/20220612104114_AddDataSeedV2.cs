using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolos.Migrations
{
    public partial class AddDataSeedV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2022, 6, 12, 10, 41, 13, 674, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2022, 6, 12, 10, 41, 13, 674, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "IdTrack", "Duration", "IdMusicAlbum", "TrackName" },
                values: new object[] { 3, 5f, 1, "Zimowowanko" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "IdTrack",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2022, 6, 12, 10, 18, 11, 931, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2022, 6, 12, 10, 18, 11, 931, DateTimeKind.Utc).AddTicks(831));
        }
    }
}
