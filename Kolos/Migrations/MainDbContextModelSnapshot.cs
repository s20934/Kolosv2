// <auto-generated />
using System;
using Kolos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kolos.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kolos.Models.Album", b =>
                {
                    b.Property<int>("IdAlbum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("IdMusicLabel")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAlbum");

                    b.HasIndex("IdMusicLabel");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            IdAlbum = 1,
                            AlbumName = "Wiosna1",
                            IdMusicLabel = 1,
                            PublishDate = new DateTime(2022, 6, 12, 10, 41, 13, 674, DateTimeKind.Utc).AddTicks(3958)
                        },
                        new
                        {
                            IdAlbum = 2,
                            AlbumName = "Wiosna1",
                            IdMusicLabel = 2,
                            PublishDate = new DateTime(2022, 6, 12, 10, 41, 13, 674, DateTimeKind.Utc).AddTicks(4594)
                        });
                });

            modelBuilder.Entity("Kolos.Models.MusicLabel", b =>
                {
                    b.Property<int>("IdMusicLabel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMusicLabel");

                    b.ToTable("MusicLabels");

                    b.HasData(
                        new
                        {
                            IdMusicLabel = 1,
                            Name = "Test1"
                        },
                        new
                        {
                            IdMusicLabel = 2,
                            Name = "Test2"
                        });
                });

            modelBuilder.Entity("Kolos.Models.Musician", b =>
                {
                    b.Property<int>("IdMusician")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdMusician");

                    b.ToTable("Musicians");

                    b.HasData(
                        new
                        {
                            IdMusician = 1,
                            FirstName = "Marek",
                            LastName = "Test",
                            Nickname = "Czarodziej"
                        },
                        new
                        {
                            IdMusician = 2,
                            FirstName = "Jarek",
                            LastName = "Test2",
                            Nickname = "Hooper"
                        });
                });

            modelBuilder.Entity("Kolos.Models.Musician_Track", b =>
                {
                    b.Property<int>("IdTrack")
                        .HasColumnType("int");

                    b.Property<int>("IdMusician")
                        .HasColumnType("int");

                    b.HasKey("IdTrack", "IdMusician");

                    b.HasIndex("IdMusician");

                    b.ToTable("Musician_Tracks");

                    b.HasData(
                        new
                        {
                            IdTrack = 1,
                            IdMusician = 1
                        },
                        new
                        {
                            IdTrack = 2,
                            IdMusician = 2
                        });
                });

            modelBuilder.Entity("Kolos.Models.Track", b =>
                {
                    b.Property<int>("IdTrack")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<int>("IdMusicAlbum")
                        .HasColumnType("int");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdTrack");

                    b.HasIndex("IdMusicAlbum");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            IdTrack = 1,
                            Duration = 3f,
                            IdMusicAlbum = 1,
                            TrackName = "Granko"
                        },
                        new
                        {
                            IdTrack = 3,
                            Duration = 5f,
                            IdMusicAlbum = 1,
                            TrackName = "Zimowowanko"
                        },
                        new
                        {
                            IdTrack = 2,
                            Duration = 3f,
                            IdMusicAlbum = 2,
                            TrackName = "Letniaczek"
                        });
                });

            modelBuilder.Entity("Kolos.Models.Album", b =>
                {
                    b.HasOne("Kolos.Models.MusicLabel", "MusicLabel")
                        .WithMany("Album")
                        .HasForeignKey("IdMusicLabel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MusicLabel");
                });

            modelBuilder.Entity("Kolos.Models.Musician_Track", b =>
                {
                    b.HasOne("Kolos.Models.Musician", "Musician")
                        .WithMany("MusicianTrack")
                        .HasForeignKey("IdMusician")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kolos.Models.Track", "Track")
                        .WithMany("MusicianTrack")
                        .HasForeignKey("IdTrack")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musician");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Kolos.Models.Track", b =>
                {
                    b.HasOne("Kolos.Models.Album", "Album")
                        .WithMany("Track")
                        .HasForeignKey("IdMusicAlbum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Kolos.Models.Album", b =>
                {
                    b.Navigation("Track");
                });

            modelBuilder.Entity("Kolos.Models.MusicLabel", b =>
                {
                    b.Navigation("Album");
                });

            modelBuilder.Entity("Kolos.Models.Musician", b =>
                {
                    b.Navigation("MusicianTrack");
                });

            modelBuilder.Entity("Kolos.Models.Track", b =>
                {
                    b.Navigation("MusicianTrack");
                });
#pragma warning restore 612, 618
        }
    }
}
