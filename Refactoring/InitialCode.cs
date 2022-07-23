//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//class Movie
//{
//    public const int Children = 2;
//    public const int Regular = 0;
//    public const int NewRelease = 1;

//    private readonly string title;
//    private int priceCode;

//    public Movie(string title, int priceCode)
//    {
//        this.title = title;
//        this.priceCode = priceCode;
//    }

//    public int GetPriceCode() => priceCode;
//    public string GetTitle() => title;

//    public void SetPriceCode(int code)
//    {
//        priceCode = code;
//    }
//}

//class Rental
//{
//    private readonly Movie movie;
//    private readonly int daysRented;

//    public Rental(Movie movie, int daysRented)
//    {
//        this.movie = movie;
//        this.daysRented = daysRented;
//    }

//    public int GetDaysRented() => daysRented;
//    public Movie GetMovie() => movie;
//}

//class Customer
//{
//    private readonly string name;
//    private readonly List<Rental> rentals = new List<Rental>();

//    public Customer(string name)
//    {
//        this.name = name;
//    }

//    public string GetName() => name;

//    public void AddRental(Rental rental)
//    {
//        rentals.Add(rental);
//    }

//    public string Statement()
//    {
//        var totalAmount = 0d;
//        var frequentRenterPoints = 0;

//        var result = "Rent" + GetName() + Environment.NewLine;
//        foreach (var rental in rentals)
//        {
//            var thisAmount = 0d;
            
//            switch (rental.GetMovie().GetPriceCode())
//            {
//                case Movie.Regular:
//                    thisAmount += 2;
//                    if (rental.GetDaysRented() > 2)
//                    {
//                        thisAmount += (rental.GetDaysRented() - 2) * 1.5;
//                    }

//                    break;

//                case Movie.NewRelease:
//                    thisAmount += rental.GetDaysRented()  * 3;
                    
//                    break;

//                case Movie.Children:
//                    thisAmount += 1.5;
//                    if (rental.GetDaysRented() > 3)
//                    {
//                        thisAmount += (rental.GetDaysRented() - 3) * 1.5;
//                    }

//                    break;

//            }

//            // Collect bonus scores
//            frequentRenterPoints++;

//            //New films two days rent bonus
//            if (rental.GetMovie().GetPriceCode() == Movie.NewRelease && rental.GetDaysRented() > 1)
//            {
//                frequentRenterPoints++;
//            }

//            //Rent details
//            result += rental.GetMovie().GetTitle() + thisAmount + Environment.NewLine;
//            totalAmount += thisAmount;

//        }

//        //Colontitul
//        result += "Debt: " + totalAmount + Environment.NewLine;
//        result += "Earn money " + frequentRenterPoints + " bonuses";

//        return result;
//    }
//}