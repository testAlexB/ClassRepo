namespace Discounts
{
    public class Product
    {
        protected string name_;
        protected double price_;
        protected int quantity_;

        public Product()
        {

        }

        public Product(string name, double price, int quantity)
        {
            name_ = name;
            price_ = price;
            quantity_ = quantity;
        }
        
        public virtual double GetDiscount()
        {
            return 0.0;
        }

        public string GetName()
        {
            return name_;
        }

        public int GetQuantity() 
        {
            return quantity_;
        }

        public double GetPrice()
        {
            return price_;
        }

        public double GetCost()
        {
            double cost = price_ * quantity_;
            double costDiscount = cost * GetDiscount();
            cost = cost - costDiscount;

            return cost;
        }
    }
}
