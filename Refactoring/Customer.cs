namespace Refactoring
{
    class Customer
    {
        private readonly string name;
        private readonly List<Rental> rentals = new List<Rental>();
        private readonly TextStatement statement = new TextStatement();

        public Customer(string name)
        {
            this.name = name;
        }

        public string GetName() => name;

        public IReadOnlyCollection<Rental> GetRentals => rentals;

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public double GetTotalAmount() => rentals.Sum(r => r.GetMovie().GetAmount(r.GetDaysRented()));

        public int GetTotalFrequentRenterPoints() => rentals.Sum(r => r.GetMovie().GetFrequentRentalPoints(r.GetDaysRented()));

        public string Statement() => statement.CreateReport(this);
    }

    class TextStatement
    {
        public string CreateReport(Customer customer)
        {
            var result = GetHeader(customer.GetName());

            result += GetBody(customer.GetRentals);

            result += GetFooter(customer.GetTotalAmount(), customer.GetTotalFrequentRenterPoints());

            return result;
        }

        private string GetHeader(string name) => "Rent" + name + Environment.NewLine;

        private string GetBody(IReadOnlyCollection<Rental> rentals)
        {
            var result = string.Empty;

            foreach (var rental in rentals)
            {
                var thisAmount = rental.GetMovie().GetAmount(rental.GetDaysRented());

                result += rental.GetMovie().GetTitle() + thisAmount + Environment.NewLine;
            }

            return result;
        }

        private string GetFooter(double totalAmount, int totalFrequentRenterPoints)
        {
            var result = "Debt: " + totalAmount + Environment.NewLine;
            result += "Earn money " + totalFrequentRenterPoints + " bonuses";

            return result;
        }
    }
}
