using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEmployes.DTOs;
using WebApiEmployes.Entities;

namespace WebApiEmployes.Utilities
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<JobPostionCreateDTO, JobPosition>();
            CreateMap<MaritalStatusCreateDTO, MaritalStatus>();
            CreateMap<GenderCreateDTO, Gender>();
            CreateMap<EmployeeCreateDTO, Employee>();
        }
    }
}
