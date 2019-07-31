using AutoMapper;
using FullStackMVC5.Models;
using FullStackMVC5.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVC5.App_Start
{
    public class MappingProfile : Profile
    {
        // Auto Mapper a Convention Name Mapping Tool
        // Mapp based on the properties names
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}