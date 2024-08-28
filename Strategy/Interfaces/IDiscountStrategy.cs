namespace DynamicDiscountSystemEx.Strategy.Interfaces
{
    public interface IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total);
    }
}
