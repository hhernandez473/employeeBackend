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
    [Route("api/gender")]
    public class GenderController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenderController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Gender>>> Get()
        {
            return await context.Genders.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult> Post(GenderCreateDTO genderDTO)
        {

            var gender = mapper.Map<Gender>(genderDTO);
            context.Add(gender);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
