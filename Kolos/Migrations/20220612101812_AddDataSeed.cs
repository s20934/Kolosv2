using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolos.Migrations
{
    public partial class AddDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MusicLabels",
                columns: new[] { "IdMusicLabel", "Name" },
                values: new object[,]
                {
                    { 1, "Test1" },
                    { 2, "Test2" }
                });

            migrationBuilder.InsertData(
                table: "Musicians",
                columns: new[] { "IdMusician", "FirstName", "LastName", "Nickname" },
                values: new object[,]
                {
                    { 1, "Marek", "Test", "Czarodziej" },
                    { 2, "Jarek", "Test2", "Hooper" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "IdAlbum", "AlbumName", "IdMusicLabel", "PublishDate" },
                values: new object[] { 1, "Wiosna1", 1, new DateTime(2022, 6, 12, 10, 18, 11, 931, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "IdAlbum", "AlbumName", "IdMusicLabel", "PublishDate" },
                values: new object[] { 2, "Wiosna1", 2, new DateTime(2022, 6, 12, 10, 18, 11, 931, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "IdTrack", "Duration", "IdMusicAlbum", "TrackName" },
                values: new object[] { 1, 3f, 1, "Granko" });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "IdTrack", "Duration", "IdMusicAlbum", "TrackName" },
                values: new object[] { 2, 3f, 2, "Letniaczek" });

            migrationBuilder.InsertData(
                table: "Musician_Tracks",
                columns: new[] { "IdMusician", "IdTrack" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Musician_Tracks",
                columns: new[] { "IdMusician", "IdTrack" },
                values: new object[] { 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musician_Tracks",
                keyColumns: new[] { "IdMusician", "IdTrack" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Musician_Tracks",
                keyColumns: new[] { "IdMusician", "IdTrack" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "IdMusician",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "IdMusician",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "IdTrack",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "IdTrack",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "IdAlbum",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicLabels",
                keyColumn: "IdMusicLabel",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicLabels",
                keyColumn: "IdMusicLabel",
                keyValue: 2);
        }
    }
}
