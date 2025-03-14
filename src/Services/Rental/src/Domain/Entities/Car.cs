namespace Rental.Domain.Entities;

public class Car
{
    public Guid Id { get; private set; }
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public int Year { get; private set; }
    public decimal PricePerDay { get; private set; }
    public bool IsAvailable { get; private set; }

    public Car(Guid id, string brand, string model, int year, decimal pricePerDay)
    {
        Id = id;
        Brand = brand;
        Model = model;
        Year = year;
        PricePerDay = pricePerDay;
        IsAvailable = true;
    }

    public void Rent()
    {
        if (!IsAvailable)
            throw new InvalidOperationException("Car is already rented.");
        IsAvailable = false;
    }

    public void Return()
    {
        IsAvailable = true;
    }
}
