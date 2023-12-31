using AutoMapper;
using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Hardwhere_API.Mapper;
using Hardwhere_API.Models;
using Hardwhere_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Hardwhere_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : ControllerBase
    {
        private readonly IRepository<Component> _componentRepository;

        private readonly IMapper _mapper;
        private readonly SearchService _searchService;
        public ComponentsController(IRepository<Component> componentRepository, SearchService searchService,  IMapper mapper)
        {
            _componentRepository = componentRepository;
            _mapper = mapper;
            _searchService = searchService;
        }

        [HttpGet]

        public ActionResult GetAllComponents()
        {
            var allcomponents = _componentRepository.GetAllComponents();
            var readAllComponentsDto = _mapper.Map<IEnumerable<ReadComponentsDTO>>(allcomponents);
            return Ok(readAllComponentsDto);
        }

        [HttpGet("Search")]

        public async Task<ActionResult> GetUserSearch(string searchText)
        {
            var allcomponents = await _searchService.CreateListDTO(searchText);
            return Ok(allcomponents);
        }

        //Este post busca componentes por el ID.
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            var component = _componentRepository.GetComponentsById(id);

            var readComponentDto = _mapper.Map<ReadComponentsDTO>(component);

            return Ok(readComponentDto);

        }


        [HttpPost]

        public ActionResult Post(CreateComponentsDTO createDTO)
        {
            var component = _mapper.Map<Component>(createDTO);

            _componentRepository.Create(component);

            return Ok();

        }


    }

    
}
