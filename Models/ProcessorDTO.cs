using Hardwhere_API.Context;

namespace Hardwhere_API.Models
{
    public class ProcessorDTO
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Cpu { get; set; } = null!;
        public string Speed { get; set; } = null!;

        public string UrlImg { get; set; } = null!;

        public ProcessorDTO(string title, string description, string cpu, string speed, string urlImg)
        {

            Title = title;
            Description = description;
            Cpu = cpu;
            Speed = speed;
            UrlImg = urlImg;

        }
    }
}
