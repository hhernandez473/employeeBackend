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
    [Route("api/jobPosition")]
    public class JobPositionController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public JobPositionController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<JobPosition>> Get(int id)
        {
            return await context.JobPositions.Include(d => d.Departament).FirstOrDefaultAsync(j => j.Id == id);
        }
        

        [HttpPost]
        public async Task<ActionResult> Post(JobPostionCreateDTO jobPositionDTO)
        {
            var exist= await context.Departaments.AnyAsync(d => d.Id == jobPositionDTO.DepartamentId);
            if (!exist)
            {
                return BadRequest($"No existe el departamento con Id {jobPositionDTO.DepartamentId}");
            }
            var jobPostion = mapper.Map<JobPosition>(jobPositionDTO);
            context.Add(jobPostion);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
