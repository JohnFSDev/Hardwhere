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


        [HttpPost]

        public ActionResult Post(CreateComponentsDTO createDTO)
        {
            var component = _mapper.Map<Component>(createDTO);

            _repository.Create(component);

            return Ok();

        }

        [HttpGet("{id}")] 
        public ActionResult Get(int id) 
        {

            var component = _repository.GetComponentsById(id);

            var readComponentDto = _mapper.Map<ReadComponentsDTO>(component);

            return Ok(readComponentDto);

        }


    }

    
}
