using System.Collections.Generic;

namespace Incapsulation
{
    public class SalesHistory
    {
        private List<Sale> sales_ = new List<Sale>();

        public void AddSale(Sale sale)
        {
            sales_.Add(sale);
        }

        public double CalcCost()
        {
            double result = 0.0;
            foreach (Sale sale in sales_) 
            {
                result += sale.CalcCost();
            }

            return result;
        }

        public List<Sale> GetSales()
        {
            return sales_;
        }
    }
}
