namespace Hardwhere_API.Models
{
    public class SupplyDTO
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ConnectorType { get; set; } = null!;

        public string Wattage { get; set; } = null!;

        public string MinimumInput { get; set; } = null!;

        public string UrlImg { get; set; } = null!;

        public SupplyDTO(string title, string description, string connectorType, string wattage, string minimumInput, string urlImg )
        {

            Title = title;
            Description = description;
            ConnectorType = connectorType;
            Wattage = wattage;
            MinimumInput = minimumInput;
            UrlImg = urlImg;

        }

    }
}
