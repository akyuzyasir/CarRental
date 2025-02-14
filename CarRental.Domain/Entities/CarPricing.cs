namespace CarRental.Domain.Entities;

public class CarPricing
{
    public decimal Amount { get; set; }

    // Nav Props
    public int CarID { get; set; }
    public Car Car { get; set; }
    public int PricingID { get; set; }
    public Pricing Pricing { get; set; }
}
