using Kolos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kolos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private readonly IDbService _dbService;
        public MusiciansController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpDelete("{idMusician}")]
        public async Task<IActionResult> DeleteMusician(int idMusician)
        {
            if (_dbService.DeleteMusician(idMusician))
            {
                return Ok("Usuniety");
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }



    }
}
