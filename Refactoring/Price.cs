namespace Refactoring;

abstract class Price
{
    public abstract double GetCharge(int daysRented);

    public virtual int GetFrequentRentalPoints(int daysRented) => 1;
}

class RegularPrice : Price
{
    private int basePrice = 2;

    public override double GetCharge(int daysRented)
    {
        return daysRented > 2
            ? basePrice + (daysRented - 2) * 1.5
            : basePrice;
    }
}

class NewReleasePrice : Price
{
    public override double GetCharge(int daysRented)
    {
        return daysRented * 3;
    }

    public override int GetFrequentRentalPoints(int daysRented)
    {
        return daysRented > 1 ? 2 : 1;
    }
}

class ChildrenPrice : Price
{
    private double basePrice = 1.5;

    public override double GetCharge(int daysRented)
    {
        return daysRented > 3
            ? basePrice + (daysRented - 3) * 1.5
            : basePrice;
    }
}