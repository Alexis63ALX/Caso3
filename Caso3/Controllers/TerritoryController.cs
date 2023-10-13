using Caso3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Caso3.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class TerritoryController : ControllerBase
    {
        private readonly Parcial20230220100619Context _context;

        public TerritoryController(Parcial20230220100619Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _context.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _context.GetById(id);
            return Ok(result);
        }

        [HttpPost()]
        public async Task<IActionResult> Create(CategoryInsertDTO territory)
        {
            var result = await _context.Insert(territory);
            if (!result)
                return BadRequest("Ocurrió un error");

            return Ok(result);
        }
    }
}
