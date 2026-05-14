namespace NewDotNet.Intermediate.Section2;

public interface IShippingCalculator
{
    float CalculateShipping(Order3 order);
}
public class ShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order3 order)
    {
        if (order.TotalPrice < 30f)
        {
            return order.TotalPrice * 0.1f;
        }

        return 0;
    }
}