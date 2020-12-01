using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public RolController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Rol> Get()
        {
            return _context.Roles.ToList();
        }

        [HttpGet("{id}")]
        public Rol Get(int id)
        {
            return _context.Roles.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public IActionResult Post(Rol valor)
        {

            _context.Roles.Add(valor);

            _context.SaveChanges();

            return Ok(valor);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Rol value)
        {

            var item = await _context.Roles.FindAsync(id);
            _context.Roles.Remove(item);
            _context.Roles.Add(value);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Roles.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Roles.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
