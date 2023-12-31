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
    public class StorageMemoryController : ControllerBase
    {
        private readonly IRepository<Supply> _repository;
        private readonly IMapper _mapper;
        public StorageMemoryController(IRepository<Supply> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var components = await _repository.GetAllComponentsIncluding<StorageMemory>(x => x.IdComponentsNavigation);
            List<ReadSearchDTO> listDTO = new List<ReadSearchDTO>();
            foreach (var liststorageDTO in components)
            {
                var readAllComponentsDto = new ReadSearchDTO
                {

                    Title = liststorageDTO.IdComponentsNavigation.Title,
                    Description = liststorageDTO.IdComponentsNavigation.Description,
                    Id = liststorageDTO.IdComponentsNavigation.Id,
                    UrlImg = liststorageDTO.UrlImg,
                    Type = liststorageDTO.IdComponentsNavigation.Type,

                };

                listDTO.Add(readAllComponentsDto);
            }

            return Ok(listDTO);
        }
    }
}
