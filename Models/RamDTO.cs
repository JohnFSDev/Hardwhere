using Hardwhere_API.Context;

namespace Hardwhere_API.Models
{
    public class RamDTO
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string RamSize { get; set; } = null!;

        public string RamTech { get; set; } = null!;

        public string RamSpeed { get; set; } = null!;

        public string UrlImg { get; set; } = null!;

        public RamDTO(string title, string description, string ramSize, string ramTech, string ramSpeed, string urlImg)
        {

            Title = title;
            Description = description;
            RamSize = ramSize;
            RamTech = ramTech;
            RamSpeed = ramSpeed;
            UrlImg = urlImg;

        }
    }
}
