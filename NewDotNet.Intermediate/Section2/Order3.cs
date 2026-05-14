namespace NewDotNet.Intermediate.Section2;

public  class Order3
{
    public int Id { get; set; }
    public DateTime DatePlaced { get; set; }
    public Shipment Shipment { get; set; }
    public float TotalPrice { get; set; }
    
    public  bool IsShipped
    {
        get { return Shipment != null; }
    }
}