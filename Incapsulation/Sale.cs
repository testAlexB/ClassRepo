using System;

namespace Incapsulation
{
    public class Sale
    {
        private int check_;
        private Product product_;
        private double count_;
        private DateTime date_;

        public Sale(int check)
        {
            check_ = check;
        }

        public Sale SetFactSale(Product product, double count)
        {
            date_ = DateTime.Now;
            product_ = product;
            count_ = count;

            return this;
        }

        public double CalcCost()
        {
            return count_ * product_.GetPrice();
        }

        public int Check() 
        { 
            return check_;
        }

        public string ConvertToString()
        {
            return $"товар {product_.ConvertToString()}, дата: {date_}, количество: {count_}, к оплате: {CalcCost()}";
        }
    }
}
