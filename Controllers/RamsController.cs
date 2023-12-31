using AutoMapper;
using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Hardwhere_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public async Task<IActionResult> Get()
        {
            var ramsComponents = await _repository.GetAllComponentsIncluding<Ram>(x => x.IdComponentsNavigation);
            List<ReadSearchDTO> listRamDTO = new();
            foreach (var listRams in ramsComponents)
            {
                var readAllComponentsDto = new ReadSearchDTO
                {

                    Title = listRams.IdComponentsNavigation.Title,
                    Description = listRams.IdComponentsNavigation.Description,
                    Id = listRams.IdComponentsNavigation.Id,
                    UrlImg = listRams.UrlImg,
                    Type = listRams.IdComponentsNavigation.Type

                };

                listRamDTO.Add(readAllComponentsDto);
            }

            return Ok(listRamDTO);
        }

    }
}
