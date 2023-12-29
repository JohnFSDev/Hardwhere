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
    public class RamsController : ControllerBase
    {

        private readonly IRepository<Ram> _repository;
        private readonly IMapper _mapper;
        public RamsController(IRepository<Ram> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult Get()
        {
            var allcomponents = _repository.GetAllComponents();
            var ramsComponents = _repository.GetAllComponentsIncluding<Ram>(x => x.IdComponentsNavigation);
            List<ReadSearchDTO> listRamDTO = new();
            foreach (var listRams in ramsComponents)
            {
                var readAllComponentsDto = new ReadSearchDTO
                {

                    Title = listRams.IdComponentsNavigation.Title,
                    Description = listRams.IdComponentsNavigation.Description,
                    Id = listRams.IdRam,
                    UrlImg = listRams.UrlImg,

                };

                listRamDTO.Add(readAllComponentsDto);
            }

            return Ok(listRamDTO);
        }

    }
}
