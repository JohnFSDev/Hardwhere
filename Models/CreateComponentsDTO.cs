namespace Hardwhere_API.Models
{
    public class CreateComponentsDTO
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string Type { get; set; } = null!;   

        public int Consults { get; private set; } = 0;

    }
}
