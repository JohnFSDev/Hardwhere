namespace Hardwhere_API.Models
{
    public class ReadSearchDTO
    {
        public int Id { get; set; }
        public string UrlImg { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
