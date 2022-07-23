namespace Refactoring;

class Rental
{
    private readonly Movie movie;
    private readonly int daysRented;

    public Rental(Movie movie, int daysRented)
    {
        this.movie = movie;
        this.daysRented = daysRented;
    }

    public int GetDaysRented() => daysRented;
    public Movie GetMovie() => movie;
}