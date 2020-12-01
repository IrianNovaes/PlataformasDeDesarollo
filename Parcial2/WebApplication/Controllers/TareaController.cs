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
    public class TareaController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public TareaController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Tarea> Get()
        {
            return _context.Tareas.ToList();
        }

        [HttpGet("{id}")]
        public Tarea Get(int id)
        {
            return _context.Tareas.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public IActionResult Post(Tarea valor)
        {

            _context.Tareas.Add(valor);

            _context.SaveChanges();

            return Ok(valor);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Tarea value)
        {

            var item = await _context.Tareas.FindAsync(id);
            _context.Tareas.Remove(item);
            _context.Tareas.Add(value);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Tareas.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Tareas.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}
