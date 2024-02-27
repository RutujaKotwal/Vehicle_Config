namespace Vehicle_Configurator.Models
{
    public class Price
    {
        private double _price;

        public Price(double price)
        {
            _price = price;
        }

        public double price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}