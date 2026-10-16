namespace Refactoring.src
{
    // Strategy Design pattern
    public interface IShippingCostCalculator
    {
        decimal Calculate(string shippingMethod, decimal weight);
    }

    public class AramexShippingCostCalculator : IShippingCostCalculator
    {
        public decimal Calculate(string shippingMethod, decimal weightKg) 
            => weightKg * 12m;
    }

    public class FedExShippingCostCalculator : IShippingCostCalculator
    {
        public decimal Calculate(string shippingMethod, decimal weightKg)
            => weightKg * 15m;
    }


    public class DHLShippingCostCalculator : IShippingCostCalculator
    {
        public decimal Calculate(string shippingMethod, decimal weightKg)
            => weightKg * 18m;
    }

    public class UPSShippingCostCalculator : IShippingCostCalculator
    {
        public decimal Calculate(string shippingMethod, decimal weightKg)
            => weightKg * 20m;
    }




    public class ShippingCostCalculator
    {
        private readonly IShippingCostCalculator _shippingCostCalculator;
        public ShippingCostCalculator(IShippingCostCalculator shippingCostCalculator)
        {
            _shippingCostCalculator = shippingCostCalculator;
        }
        public decimal Calculate(string shippingMethod, decimal weightKg)
        {
            decimal salary = _shippingCostCalculator.Calculate(shippingMethod, weightKg);
            return salary;
        }
    }
}
