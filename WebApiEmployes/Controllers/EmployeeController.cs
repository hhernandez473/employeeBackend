using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEmployes.DTOs;
using WebApiEmployes.Entities;

namespace WebApiEmployes.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public EmployeeController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return await context.Employee.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult> Post(EmployeeCreateDTO employeeDTO)
        {
            var existJobPosition = await context.JobPositions.AnyAsync(d => d.Id == employeeDTO.JobPositonID);
            if (!existJobPosition)
            {
                return BadRequest($"No existe el puesto con Id {employeeDTO.JobPositonID}");
            }

            var existGender = await context.Genders.AnyAsync(d => d.Id == employeeDTO.GenderId);
            if (!existGender)
            {
                return BadRequest($"No existe el genero con Id {employeeDTO.JobPositonID}");
            }

            var existMaritalStatus = await context.MaritalStatus.AnyAsync(d => d.Id == employeeDTO.MaritalStatusId);
            if (!existMaritalStatus)
            {
                return BadRequest($"No existe el genero con Id {employeeDTO.JobPositonID}");
            }

            var employee = mapper.Map<Employee>(employeeDTO);
            context.Add(employee);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, EmployeeCreateDTO employeeDTO)
        {
           
            var employeeDB = await context.Employee.FirstOrDefaultAsync(d => d.Id == id);
            if (employeeDB == null)
            {
                return NotFound();
            }

            employeeDB = mapper.Map(employeeDTO, employeeDB);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await context.Employee.AnyAsync(d => d.Id == id);
            if (!exist)
            {
                return NotFound();
            }
            context.Remove(new Employee() { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
