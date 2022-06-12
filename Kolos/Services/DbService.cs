using Kolos.Models;
using Kolos.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos.Services
{
    public class DbService : IDbService
    {

        private readonly MainDbContext _dbContext;
        public DbService(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool DeleteMusician(int idMusician)
        {
            
            var ifTrackInAlbum = _dbContext.Musician_Tracks.Single(p => p.IdMusician == idMusician);
            var trackId = ifTrackInAlbum.IdTrack;
            var Track =  _dbContext.Tracks.Single(p => p.IdTrack == trackId);
            var checkIfInAlbum = Track.IdMusicAlbum;

            if(checkIfInAlbum == null)
            {
                _dbContext.Remove(_dbContext.Musicians.Single(e => e.IdMusician == idMusician));
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public async Task<IEnumerable<AlbumInformation>> GetAlbum(int idAlbum)
        {

            return await _dbContext.Albums
                .Where(p => p.IdAlbum == idAlbum)
                .Include(p => p.Track)
                .Select(p => new AlbumInformation {
                
                    IdAlbum = p.IdAlbum,
                    AlbumName = p.AlbumName,
                    PublishDate = p.PublishDate,
                    Tracks = p.Track
                    
                }).ToListAsync();



        }
    }
}
