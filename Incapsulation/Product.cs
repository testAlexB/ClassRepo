namespace Incapsulation
{
    public class Product
    {
        private string name_;
        private double price_;

        public Product(string n, double p)
        {
            name_ = n;
            price_ = p;
        }

        public double GetPrice()
        {
            return price_;
        }

        public string ConvertToString()
        {
            return name_;
        }
    }
}
