namespace CarRental.Domain.Entities;

public class Feature
{
    public int FeatureId { get; set; }
    public string Name { get; set; }

    // Nav Props
    public List<CarFeature> CarFeatures { get; set; }

}
