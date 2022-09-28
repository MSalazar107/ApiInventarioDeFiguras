﻿using ApiInventarioDeFiguras.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiInventarioDeFiguras.Controllers
{
    [ApiController]
    [Route("figuras")]
    public class InventarioController: ControllerBase
    {
        private ApplicationDbContext dbContext;
        public InventarioController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task <ActionResult<List<Figura>>> Get()
        {
            return await dbContext.Figuras.Include(x => x.Wave).ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Figura>> GetById(int id)
        {
            return await dbContext.Figuras.FirstOrDefaultAsync(x => x.Id == id);
           
        }

        [HttpPost]

        public async Task<ActionResult> Post(Figura figura) 
        {
            dbContext.Add(figura);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Figura figura, int id ) 
        {
            if(figura.Id != id)
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
