namespace Refactoring;

class Movie
{
    private readonly string title;
    private Price price;

    public Movie(string title, PriceType priceType)
    {
        this.title = title;
        SetPrice(priceType);
    }

    public string GetTitle() => title;

    public double GetAmount(int daysRented) => price.GetCharge(daysRented);

    public int GetFrequentRentalPoints(int daysRented) => price.GetFrequentRentalPoints(daysRented);

    public void SetPrice(PriceType priceType)
    {
        price = PriceFactory.CreatePrice(priceType);
    }
}