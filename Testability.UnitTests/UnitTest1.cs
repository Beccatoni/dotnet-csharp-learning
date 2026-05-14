using NewDotNet.Intermediate.Section2;

namespace Testability.UnitTests;

public class OrderProcessorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Process_OrderIsAlreadyShipped_ThrowAnException()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order3
        {
            Shipment = new Shipment()
        };

        Assert.Throws<InvalidOperationException>( () => orderProcessor.Process(order));
    }

    [Test]
    public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order3();
        
        orderProcessor.Process(order);
        Assert.IsTrue(order.IsShipped);
        Assert.IsNotNull(order.Shipment);
        Assert.AreEqual(1, order.Shipment.Cost);
        Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
    }
}

public class FakeShippingCalculator: IShippingCalculator
{
    public float CalculateShipping(Order3 order)
    {
        return 1;
    }
}