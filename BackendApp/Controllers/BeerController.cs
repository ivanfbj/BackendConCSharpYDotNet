using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BackendApp.Models;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hola mundo";
        }

        [HttpGet("GetBeer")]
        public Beer GetBeer()
        {
            var beer = new Beer()
            {
                BeerId = 1,
                Name = "Erdinger",
            };

            return beer;
        }
    }
}
