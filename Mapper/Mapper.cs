using AutoMapper;
using Hardwhere_API.Context;
using Hardwhere_API.Models;

namespace Hardwhere_API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper() 
        {

            CreateMap<Component, ReadComponentsDTO>();
            CreateMap<CreateComponentsDTO, Component>();
        }
    }
}
