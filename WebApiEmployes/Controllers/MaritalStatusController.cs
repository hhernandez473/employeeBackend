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
    [Route("api/maritalStatus")]
    public class MaritalStatusController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public MaritalStatusController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<MaritalStatus>>> Get()
        {
            return await context.MaritalStatus.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult> Post(MaritalStatusCreateDTO maritalStatusDTO)
        {
                      
            var maritalStatus = mapper.Map<MaritalStatus>(maritalStatusDTO);
            context.Add(maritalStatus);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
