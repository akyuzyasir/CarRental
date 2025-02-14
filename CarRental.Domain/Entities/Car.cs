namespace CarRental.Domain.Entities;

public class Car
{
    public int CarId { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public int Milage { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public byte Luggage { get; set; }
    public string FuelType { get; set; }
    public string BigImageUrl { get; set; }

    // Nav Props
    public List<CarFeature> CarFeatures { get; set; }
    public List<CarDescription> CarDescriptions { get; set; }
    public List<CarPricing> CarPricings { get; set; }


}
