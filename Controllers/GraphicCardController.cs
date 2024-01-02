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
    public class GraphicCardController : ControllerBase
    {

        private readonly IRepository<GraphicCard> _repository;
        private readonly IMapper _mapper;
        public GraphicCardController(IRepository<GraphicCard> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var components = await _repository.GetAllComponentsIncluding<GraphicCard>(x => x.IdComponentsNavigation);
            List<ReadSearchDTO> listDTO = new();
            foreach (var list in components)
            {
                var readAllComponentsDto = new ReadSearchDTO
                {

                    Title = list.IdComponentsNavigation.Title,
                    Description = list.IdComponentsNavigation.Description,
                    Id = list.IdComponentsNavigation.Id,
                    UrlImg = list.UrlImg,
                    Type = list.IdComponentsNavigation.Type


                };

                listDTO.Add(readAllComponentsDto);
            }

            return Ok(listDTO);
        }

    }
}
