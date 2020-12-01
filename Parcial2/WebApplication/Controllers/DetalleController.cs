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
    public class DetalleController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public DetalleController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalle> Get()
        {
            return  _context.Detalles.ToList();
        }

        [HttpGet("{id}")]
        public Detalle Get(int id)
        {
            return _context.Detalles.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public IActionResult Post(Detalle valor)
        {
                          
            _context.Detalles.Add(valor);
          
            _context.SaveChanges();

            return Ok(valor);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Detalle value)
        {

            var item = await _context.Detalles.FindAsync(id);
            _context.Detalles.Remove(item);
            _context.Detalles.Add(value);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var detalle = await _context.Detalles.FindAsync(id);

            if (detalle == null)
            {
                return NotFound();
            }

            _context.Detalles.Remove(detalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
