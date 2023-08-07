﻿using AutoMapper;
using Bl.Data;
using Domains;
using Domains.ViewModels;

namespace It_Legend.Models
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Jobs, JobsWithRlated>().ReverseMap();
            CreateMap<ApplicationUser,userModel>().ReverseMap();
            CreateMap<Candidates, ApplicationUser>().ReverseMap()
                .ForMember(c => c.userId, u => u.MapFrom(u => u.Id));
            CreateMap<Employees, ApplicationUser>().ReverseMap()
                .ForMember(e => e.userId, u => u.MapFrom(u => u.Id));
        }
    }
}