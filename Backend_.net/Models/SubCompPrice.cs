
namespace Vehicle_Configurator.Models
{
    public class SubCompPrice
    {
        public string SubType { get; set; }
        public double DeltaPrice { get; set; }
        public int AltId { get; set; }

        public SubCompPrice()
        {

        }
        public SubCompPrice(string subType, double deltaPrice, int altId)
        {
            SubType = subType;
            DeltaPrice = deltaPrice;
            AltId = altId;
        }
    }
}
