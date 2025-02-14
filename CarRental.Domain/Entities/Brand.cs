namespace CarRental.Domain.Entities;

public class Brand
{
    public int BrandID { get; set; }
    public string Name { get; set; }

    // Nav Props
    public List<Car> Cars { get; set; }
}
