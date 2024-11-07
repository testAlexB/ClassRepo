namespace Discounts
{
    public class Water : Product
    {
        public Water(string name, double price, int quantity) : base(name, price, quantity)
        {
        }

        public override double GetDiscount()
        {
            if (quantity_ >= 5 && quantity_ < 10)
            {
                return 0.01;
            }

            if (quantity_ >= 10)
            {
                return 0.5;
            }

            return 0.0;
        }
    }
}
