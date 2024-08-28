using DynamicDiscountSystemEx.Strategy.Interfaces;

namespace DynamicDiscountSystemEx.Strategy.Classes
{
    public class PercentageDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total -  (total * 0.10M);
        }
    }
}
