using Kolos.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kolos.Services
{
    public interface IDbService
    {
        Task<IEnumerable<AlbumInformation>> GetAlbum(int idAlbum);
        bool DeleteMusician(int idMusician);
    }
}
