using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEmployes.Entities;

namespace WebApiEmployes.Controllers
{
    [ApiController]
    [Route("api/departament")]
    public class DepartamentController: ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DepartamentController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Departament>>> Get()
        {
            return await context.Departaments.Include(j => j.JobPositions).ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult> Post(Departament departament)
        {
            context.Add(departament);
            await context.SaveChangesAsync();
            return Ok();
        }

        
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Departament departament, int id)
        {
            if (departament.Id != id)
            {
                return BadRequest("El id del departamento no es correcto");
            }
            var exist = await context.Departaments.AnyAsync(d => d.Id == id);
            if (!exist)
            {
                return NotFound();
            }
            context.Update(departament);
            await context.SaveChangesAsync();
            return Ok();
        }

        //[HttpDelete("{id: int}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var exist = await context.Departaments.AnyAsync(d => d.Id == id);
        //    if (!exist)
        //    {
        //        return NotFound();
        //    }
        //    context.Remove(new Departament() { Id = id });
        //    await context.SaveChangesAsync();
        //    return Ok();
        //}
    }
}
