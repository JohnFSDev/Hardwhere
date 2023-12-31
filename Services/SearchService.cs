using AutoMapper;
using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Hardwhere_API.Models;
using Hardwhere_API.Repositories;
using Newtonsoft.Json;

namespace Hardwhere_API.Services
{
    public class SearchService
    {
        private readonly IRepository<Component> _componentRepository;
        private readonly IRepository<GraphicCard> _graphicCardRepository;
        private readonly IRepository<Processor> _processorRepository;
        private readonly IRepository<Ram> _ramRepository;
        private readonly IRepository<StorageMemory> _storageMemoryRepository;
        private readonly IRepository<Supply> _supplyRepository;

        private readonly IMapper _mapper;
        public SearchService(IRepository<Component> componentRepository, IRepository<GraphicCard> graphicCardRepository, IRepository<Processor> processorRepository, IRepository<Ram> ramRepository, IRepository<StorageMemory> storageMemoryRepository, IRepository<Supply> supplyRepository, IMapper mapper)
        {
            _componentRepository = componentRepository;
            _mapper = mapper;
            _graphicCardRepository = graphicCardRepository;
            _processorRepository = processorRepository;
            _ramRepository = ramRepository;
            _storageMemoryRepository = storageMemoryRepository;
            _supplyRepository = supplyRepository;
        }
        public async Task<List<ReadSearchDTO>> ConvertGraphicToDTO()
        {
            var component = await _graphicCardRepository.GetAllComponentsIncluding<GraphicCard>(x => x.IdComponentsNavigation);

            List<ReadSearchDTO> listDTO = new();
            foreach (var list in component)
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

            return (listDTO);

        }

        public async Task<List<ReadSearchDTO>> ConvertProcessorToDTO()
        {
            var component = await _processorRepository.GetAllComponentsIncluding<Processor>(x => x.IdComponentsNavigation);

            List<ReadSearchDTO> listDTO = new();
            foreach (var list in component)
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

            return (listDTO);

        }

        public async Task<List<ReadSearchDTO>> ConvertRamToDTO()
        {
            var component = await _ramRepository.GetAllComponentsIncluding<Ram>(x => x.IdComponentsNavigation);

            List<ReadSearchDTO> listDTO = new();
            foreach (var list in component)
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

            return (listDTO);

        }

        public async Task<List<ReadSearchDTO>> ConvertStorageMemoryToDTO()
        {
            var component = await _storageMemoryRepository.GetAllComponentsIncluding<StorageMemory>(x => x.IdComponentsNavigation);

            List<ReadSearchDTO> listDTO = new();
            foreach (var list in component)
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

            return (listDTO);

        }

        public async Task<List<ReadSearchDTO>> ConvertSupplyToDTO()
        {
            var component = await _supplyRepository.GetAllComponentsIncluding<Supply>(x => x.IdComponentsNavigation);

            List<ReadSearchDTO> listDTO = new();
            foreach (var list in component)
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

            return (listDTO);

        }

        public List<ReadSearchDTO> SearchFilter(List<ReadSearchDTO> generics, string searchText)
        {
            generics = generics.Where(e => e.Title.ToLower().Contains(searchText) || e.Description.ToLower().Contains(searchText)).ToList();
            return generics;
        }
        public async Task<List<ReadSearchDTO>> CreateListDTO(string searchText)
        {
            var graphicDTO = await ConvertGraphicToDTO();
            var processorDTO = await ConvertProcessorToDTO();
            var ramDTO = await ConvertRamToDTO();
            var storageMemoryDTO = await ConvertStorageMemoryToDTO();
            var supplyDTO = await ConvertSupplyToDTO();

            List<ReadSearchDTO> listDTO = new();

            listDTO.AddRange(graphicDTO);
            listDTO.AddRange(processorDTO);
            listDTO.AddRange(ramDTO);
            listDTO.AddRange(storageMemoryDTO);
            listDTO.AddRange(supplyDTO);

            var filteredList = SearchFilter(listDTO, searchText);


            return filteredList;
        }

    }
}
