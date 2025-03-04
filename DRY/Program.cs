namespace codingPrinciples.DRY
{
    class Program
    {
        static void Main()
        {
            CarRentalService rentalService = new CarRentalService();

            decimal sedanPrice = rentalService.CalculatePrice(10, 50);
            decimal goodCarPrice = rentalService.CalculatePrice(10, 40);

            Console.WriteLine($"sedan price ${sedanPrice}");
            Console.WriteLine($"Good car price ${goodCarPrice}");


        }
    }
}
