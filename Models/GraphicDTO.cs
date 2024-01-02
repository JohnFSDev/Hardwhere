namespace Hardwhere_API.Models
{
    public class GraphicDTO
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Coprocessor { get; set; } = null!;
        public string VramSize { get; set; } = null!;
        public string UrlImg { get; set; } = null!;

        public GraphicDTO(string title, string description, string coprocessor, string vramSize, string urlImg) 
        {

            Title = title;
            Description = description;
            Coprocessor = coprocessor;
            VramSize = vramSize;
            UrlImg = urlImg;

        }
    }

}
