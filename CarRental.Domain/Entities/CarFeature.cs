namespace CarRental.Domain.Entities;

public class CarFeature
{
    public bool Available { get; set; }

    // Nav Props
    public int CarFeatureID { get; set; }
    public int CarID { get; set; }
    public Feature Feature { get; set; }
    public Car Car { get; set; }
}
