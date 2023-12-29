using AutoMapper;
using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Hardwhere_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hardwhere_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessorController : ControllerBase
    {

        private readonly IRepository<Processor> _repository;
        private readonly IMapper _mapper;
        public ProcessorController(IRepository<Processor> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult Get()
        {

            var components = _repository.GetAllComponentsIncluding<Processor>(x => x.IdComponentsNavigation);
            List<ReadSearchDTO> listDTO = new();
            foreach (var list in components)
            {
                var readAllComponentsDto = new ReadSearchDTO
                {

                    Title = list.IdComponentsNavigation.Title,
                    Description = list.IdComponentsNavigation.Description,
                    Id = list.IdProcessor,
                    UrlImg = list.UrlImg,

                };

                listDTO.Add(readAllComponentsDto);
            }

            return Ok(listDTO);
        }
    }
}
