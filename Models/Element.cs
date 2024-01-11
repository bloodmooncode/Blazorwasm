namespace Blazorwasm.Models
{
  
    public class Element
    {
        public int id { get; set; } = 0;
        public int userId { get; set; } = 0;
        public string name { get; set; } = "";
        public string timeHorizon { get; set; } = "";
        public int interval { get; set; } = 0;

        public string type { get; set; } = "";
        public double maximumBuyingPower { get; set; } = 0.0;
        public double minimumBuyingPower { get; set; } = 0.0;
        public double maximumSellingPower { get; set; } = 0.0;
        public double minimumSellingPower { get; set; } = 0.0;

    }
}

