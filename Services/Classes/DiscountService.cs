using DynamicDiscountSystemEx.Services.Interfaces;
using DynamicDiscountSystemEx.Strategy.Classes;
using DynamicDiscountSystemEx.Strategy.Interfaces;

namespace DynamicDiscountSystemEx.Services.Classes
{
    public class DiscountService : IDiscountService
    {
        public decimal ApplyDiscount(decimal total)
        {
            if (total < 50)
            {
                return new NoDiscount().ApplyDiscount(total);
            }
            else if (total >= 50 && total <= 200)
            {
                return new PercentageDiscount().ApplyDiscount(total);
            }
            else
            {
                return new FlatAmountDiscount().ApplyDiscount(total);
            }
        }
    }
}
