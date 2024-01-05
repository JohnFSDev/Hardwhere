using AutoMapper;
using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Hardwhere_API.Mapper;
using Hardwhere_API.Models;
using Hardwhere_API.Repositories;
using Hardwhere_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        [HttpGet("Consults")]

        public ActionResult MostSearched()
        {
            var allcomponents = _componentRepository.GetAllComponents().OrderByDescending(x => x.Consults);
            
            var readAllComponentsDto = _mapper.Map<IEnumerable<ReadComponentsDTO>>(allcomponents);
            return Ok(readAllComponentsDto);
        }
        [HttpGet("Search")]

        public async Task<ActionResult> GetUserSearch(string searchText,  float pageResults, int page = 0)
        {
            var filterComponents = await _searchService.CreateListDTO(searchText);
            var componentsPaginate = await _searchService.PaginateList(filterComponents, page, pageResults);
            return Ok(componentsPaginate);
        }


        //Este post busca componentes por el ID.
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var component = _componentRepository.GetComponentsById(id);
            
            //Aumenta las consultas
            component.Consults += 1;
            //Actualiza la base de datos con las consultas
            _componentRepository.Update(component);

            switch (component.Type)
            {
                case "graphic":

                    
                    var graphics = _componentRepository.GetComponentsByIdIncluding<Component>(e => e.Id == id, g => g.GraphicCard);

                    GraphicDTO graphicsDTO = new(graphics.Title, graphics.Description, graphics.GraphicCard.Coprocessor, graphics.GraphicCard.VramSize, graphics.GraphicCard.UrlImg);

                    return Ok(graphicsDTO);

                ////graphicsDTO.Assign(graphics.Title, graphics.Description, graphics.GraphicCard.Coprocessor, graphics.GraphicCard.VramSize, graphics.GraphicCard.UrlImg);

                case "processor":

                    var processor = _componentRepository.GetComponentsByIdIncluding<Component>(e => e.Id == id, g => g.Processor);

                    ProcessorDTO processorDTO = new(processor.Title, processor.Description, processor.Processor.Cpu,processor.Processor.Speed, processor.Processor.UrlImg);


                    return Ok(processorDTO);

                case "ram":

                    var ram = _componentRepository.GetComponentsByIdIncluding<Component>(e => e.Id == id, g => g.Ram);

                    RamDTO ramDTO = new(ram.Title, ram.Description, ram.Ram.RamSize, ram.Ram.RamTech, ram.Ram.RamSpeed, ram.Ram.UrlImg);


                    return Ok(ramDTO);

                case "storage":

                    var storage = _componentRepository.GetComponentsByIdIncluding<Component>(e => e.Id == id, g => g.StorageMemory);

                    StorageMemoryDTO storageDTO = new(storage.Title, storage.Description,storage.StorageMemory.Storage,storage.StorageMemory.ConnectivityTech, storage.StorageMemory.UrlImg);


                    return Ok(storageDTO);

                case "supply":

                    var supply = _componentRepository.GetComponentsByIdIncluding<Component>(e => e.Id == id, g => g.Supply);

                    SupplyDTO supplyDTO = new(supply.Title, supply.Description, supply.Supply.ConnectorType, supply.Supply.Wattage,supply.Supply.MinimumInput,supply.Supply.UrlImg);


                    return Ok(supplyDTO);
            }

            return Ok(component);

        }


        //[HttpPost]

        //public ActionResult Post(CreateComponentsDTO createDTO)
        //{
        //    var component = _mapper.Map<Component>(createDTO);

        //    _componentRepository.Create(component);

        //    return Ok();

        //}


    }

    
}
