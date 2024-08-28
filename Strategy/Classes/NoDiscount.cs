using DynamicDiscountSystemEx.Strategy.Interfaces;

namespace DynamicDiscountSystemEx.Strategy.Classes
{
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total;
        }

   
    }
}
