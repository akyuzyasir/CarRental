﻿namespace CarRental.Domain.Entities;

public class CarDescription
{
    public int CarDescriptionID { get; set; }
    public string Details { get; set; }

    // Nav Props
    public int CarID { get; set; }
    public Car Car { get; set; }
}
