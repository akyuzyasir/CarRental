namespace CarRental.Domain.Entities;

public class Pricing
{
    public int PricingID { get; set; }
    public string Name { get; set; }

    //Nav Props
    public List<CarPricing> CarPricings { get; set; }
}
