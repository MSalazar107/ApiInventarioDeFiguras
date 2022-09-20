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
        public async Task<ActionResult<List<Wave>>> Get()
        {
            return await dbContext.Waves.ToListAsync();
        }

        [HttpPost]

        public async Task<ActionResult> Post(Wave figura)
        {
            dbContext.Add(figura);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Wave wave, int id)
        {
            if (wave.Id != id)
            {
                return BadRequest("El id de la figura no coincide con el establecido en la url.");
            }

            dbContext.Update(wave);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var waveDel = await dbContext.Figuras.FindAsync(id);
            dbContext.Figuras.Remove(waveDel);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
