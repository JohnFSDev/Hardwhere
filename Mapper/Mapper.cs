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
            CreateMap<Component, CreateComponentsDTO>();
            CreateMap<GraphicCard, ReadSearchDTO>();
            CreateMap<Processor, ReadSearchDTO>();
            CreateMap<Ram, ReadSearchDTO>();
            CreateMap<StorageMemory, ReadSearchDTO>();
            CreateMap<Supply, ReadSearchDTO>();
            CreateMap<Component, GraphicDTO>();
            CreateMap<Component, RamDTO>();
            CreateMap<CreateComponentsDTO, Component>();

        }
    }
}
