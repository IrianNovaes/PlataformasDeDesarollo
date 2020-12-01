using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entidades;


namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoTareaController : ControllerBase
    {
        private readonly TareasDbContext _context;
        public TipoTareaController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<TipoTarea> Get()
        {
            return _context.TipoTareas.ToList();
        }

        [HttpGet("{id}")]
        public TipoTarea Get(int id)
        {
            return _context.TipoTareas.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public IActionResult Post(TipoTarea valor)
        {
            if (valor.Id == 0)
            {
                _context.TipoTareas.Add(valor);
            }
            else
            {
                _context.TipoTareas.Attach(valor);
                _context.TipoTareas.Update(valor);
            }
            _context.SaveChanges();
            return Ok(valor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TipoTarea value)
        {

            var item = await _context.TipoTareas.FindAsync(id);
            _context.TipoTareas.Remove(item);
            _context.TipoTareas.Add(value);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.TipoTareas.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.TipoTareas.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}