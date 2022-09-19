using ApiInventarioDeFiguras.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiInventarioDeFiguras.Controllers
{
    [ApiController]
    [Route("/Marca")]
    public class WaveController :ControllerBase 
    {
        private readonly ApplicationDbContext dbContext;
        public WaveController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Figura>>> Get()
        {
            return await dbContext.Figuras.ToListAsync();
        }

        [HttpPost]

        public async Task<ActionResult> Post(Figura figura)
        {
            dbContext.Add(figura);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Figura figura, int id)
        {
            if (figura.Id != id)
            {
                return BadRequest("El id de la figura no coincide con el establecido en la url.");
            }

            dbContext.Update(figura);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var figuraDel = await dbContext.Figuras.FindAsync(id);
            dbContext.Figuras.Remove(figuraDel);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
