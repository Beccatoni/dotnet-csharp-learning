using System.Reflection.Metadata.Ecma335;

namespace NewDotNet.Intermediate.Section2;

public class OrderProcessor
{
    private readonly IShippingCalculator _shippingCalculator;

    public OrderProcessor(IShippingCalculator shippingCalculator)
    {
        _shippingCalculator = shippingCalculator;
    }

    public void Process(Order3 order3)
    {
        if (order3.IsShipped)
        {
            throw new InvalidOperationException("This order is already processed.");
        }

        order3.Shipment = new Shipment
        {
            Cost = _shippingCalculator.CalculateShipping(order3),
            ShippingDate = DateTime.Today.AddDays(1)
        };
    }
}

public class Shipment
{
    public DateTime ShippingDate { get; set; }
    public float Cost { get; set; }
}