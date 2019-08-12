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
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<MovieGenre, MovieGenreDto>();
            Mapper.CreateMap<Rental, NewRentalDto>();



            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}