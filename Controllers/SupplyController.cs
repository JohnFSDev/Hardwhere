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
    public class SupplyController : ControllerBase
    {
        private readonly IRepository<Supply> _repository;
        private readonly IMapper _mapper;
        public SupplyController(IRepository<Supply> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult Get()
        {

            var components = _repository.GetAllComponentsIncluding<Supply>(x => x.IdComponentsNavigation);
            List<ReadSearchDTO> listDTO = new List<ReadSearchDTO>();
            foreach (var listsupplysDTO in components)
            {
                var readAllComponentsDto = new ReadSearchDTO
                {

                    Title = listsupplysDTO.IdComponentsNavigation.Title,
                    Description = listsupplysDTO.IdComponentsNavigation.Description,
                    Id = listsupplysDTO.IdSupply,
                    UrlImg = listsupplysDTO.UrlImg,

                };

                listDTO.Add(readAllComponentsDto);
            }

            return Ok(listDTO);
        }
    }
}
