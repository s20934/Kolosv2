using Microsoft.EntityFrameworkCore;
using System;

namespace Kolos.Models
{
    public class MainDbContext : DbContext
    {
        protected MainDbContext()
        {

        }
        public MainDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Musician_Track> Musician_Tracks { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Musician>(p =>
            {
                p.HasData(
                    new Musician { IdMusician = 1, FirstName = "Marek", LastName = "Test" , Nickname = "Czarodziej"},
                    new Musician { IdMusician = 2, FirstName = "Jarek", LastName = "Test2" , Nickname = "Hooper"}
                    );



            });

            modelbuilder.Entity<Musician_Track>(p =>
            {
                p.HasKey(d => new { d.IdTrack, d.IdMusician });

                p.HasData(
                   new Musician_Track { IdMusician = 1, IdTrack = 1 },
                   new Musician_Track { IdMusician = 2, IdTrack = 2 }
           
                   );

            });

            modelbuilder.Entity<Track>(p =>
            {
                p.HasData(
                  new Track { IdTrack = 1, TrackName = "Granko", Duration = 3, IdMusicAlbum  = 1},
                  new Track { IdTrack = 3, TrackName = "Zimowowanko", Duration = 5, IdMusicAlbum  = 1},
                  new Track { IdTrack = 2, TrackName = "Letniaczek", Duration = 3, IdMusicAlbum = 2}

                  );


            });

            modelbuilder.Entity<Album>(p =>
            {
                p.HasData(
                 new Album {IdAlbum = 1,AlbumName = "Wiosna1", PublishDate = DateTime.UtcNow, IdMusicLabel = 1},
                 new Album {IdAlbum = 2,AlbumName = "Wiosna1", PublishDate = DateTime.UtcNow, IdMusicLabel = 2}
           

                 );

            });

            modelbuilder.Entity<MusicLabel>(p =>
            {
                p.HasData(
               new MusicLabel { IdMusicLabel = 1, Name = "Test1" },
               new MusicLabel { IdMusicLabel = 2, Name = "Test2" }


               );


            });

        }
    }
}
