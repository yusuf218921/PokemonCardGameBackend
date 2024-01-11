using DataAccess.Concrete.EfCore.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly RepositoryContext _context;
        public PokemonsController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = _context.Pokemons.ToList();
            return Ok(entities);
        }
    }
}
