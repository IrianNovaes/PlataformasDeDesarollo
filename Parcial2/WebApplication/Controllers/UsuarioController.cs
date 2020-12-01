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
    public class UsuarioController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public UsuarioController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _context.Usuarios.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public IActionResult Post(Usuario valor)
        {

            _context.Usuarios.Add(valor);

            _context.SaveChanges();

            return Ok(valor);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Usuario value)
        {

            var item = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(item);
            _context.Usuarios.Add(value);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Usuarios.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
