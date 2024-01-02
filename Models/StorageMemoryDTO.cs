namespace Hardwhere_API.Models
{
    public class StorageMemoryDTO
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Storage { get; set; } = null!;

        public string ConnectivityTech { get; set; } = null!;

        public string UrlImg { get; set; } = null!;

        public StorageMemoryDTO(string title, string description, string storage, string connectivityTech, string urlImg)
        {

            Title = title;
            Description = description;
            Storage = storage;
            ConnectivityTech = connectivityTech;
            UrlImg = urlImg;

        }
    }
}
