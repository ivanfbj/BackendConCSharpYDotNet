using DB;
using Microsoft.AspNetCore.Mvc;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private BackendBarContext _context;

        public BeerController(BackendBarContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Beer> Get()=> _context.Beers.ToList();
    }
}
