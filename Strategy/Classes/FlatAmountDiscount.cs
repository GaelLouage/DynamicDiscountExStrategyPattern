using DynamicDiscountSystemEx.Strategy.Interfaces;

namespace DynamicDiscountSystemEx.Strategy.Classes
{
    public class FlatAmountDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total - 30;
        }
    }
}
