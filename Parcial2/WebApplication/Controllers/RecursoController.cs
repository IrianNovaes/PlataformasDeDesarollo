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
    public class RecursoController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public RecursoController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Recurso> Get()
        {
            return _context.Recursos.ToList();
        }

        [HttpGet("{id}")]
        public Recurso Get(int id)
        {
            return _context.Recursos.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public IActionResult Post(Recurso valor)
        {

            _context.Recursos.Add(valor);

            _context.SaveChanges();

            return Ok(valor);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Recurso value)
        {

            var item = await _context.Recursos.FindAsync(id);
            _context.Recursos.Remove(item);
            _context.Recursos.Add(value);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Recursos.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Recursos.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
