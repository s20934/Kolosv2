using Kolos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kolos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IDbService _dbService;
        public AlbumsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{idAlbum}")]
        public async Task<IActionResult> GetAlbum(int idAlbum)
        {
            Console.WriteLine(idAlbum);
            var resultAlbum = await _dbService.GetAlbum(idAlbum);

            if(resultAlbum == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            else
            {
                return Ok(resultAlbum);
            }
           

        }



    }
}
