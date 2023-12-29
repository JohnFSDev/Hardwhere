using AutoMapper;
using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Hardwhere_API.Mapper;
using Hardwhere_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Hardwhere_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : ControllerBase
    {
        private readonly IRepository<Component> _repository;
        private readonly IMapper _mapper;
        public ComponentsController(IRepository<Component> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            
        }

        [HttpGet]

        public ActionResult GetAllComponents()
        {
            var allcomponents = _repository.GetAllComponents();
            var readAllComponentsDto = _mapper.Map<IEnumerable<ReadComponentsDTO>>(allcomponents);
            return Ok(readAllComponentsDto);
        }

        //Este post busca componentes por el ID.
        [HttpGet("{id}")] 
        public ActionResult Get(int id) 
        {

            var component = _repository.GetComponentsById(id);

            var readComponentDto = _mapper.Map<ReadComponentsDTO>(component);

            return Ok(readComponentDto);

        }

        //[HttpGet("rams")]

        //public ActionResult GetAllRams()
        //{
        //    var allrams = _repository.GetAllRams();
        //    var readAllRamsDto = _mapper.Map<IEnumerable<ReadComponentsDTO>>(allrams);
        //    return Ok(readAllRamsDto);

        //}

        // Este post crear nuevos componentes
        [HttpPost]

        public ActionResult Post(CreateComponentsDTO createDTO)
        {
            var component = _mapper.Map<Component>(createDTO);

            _repository.Create(component);

            return Ok();

        }

      



    }

    
}
