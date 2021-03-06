using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/libros")]
    public class LibrosController: ControllerBase
    {
        private readonly ApplicationDbContex context;

        public LibrosController(ApplicationDbContex context)
        {
            this.context = context;
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Libro>> Get(int id) 
        {
            return await context.Libros.Include(x => x.Autor).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Libro libro)
        {
            var existe = await context.Autores.AnyAsync(x => x.Id == libro.AutorId);

            if (!existe)
            {
                return BadRequest($"No existe el autor de id:{libro.AutorId}");
            }
            context.Libros.Add(libro);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
