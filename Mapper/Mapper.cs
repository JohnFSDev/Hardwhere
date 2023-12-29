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
            CreateMap<GraphicCard, ReadSearchDTO>();
            CreateMap<Processor, ReadSearchDTO>();
            CreateMap<Ram, ReadSearchDTO>();
            CreateMap<StorageMemory, ReadSearchDTO>();
            CreateMap<Supply, ReadSearchDTO>();
        }
    }
}
