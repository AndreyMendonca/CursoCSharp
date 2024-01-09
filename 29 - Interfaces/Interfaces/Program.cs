using Interfaces.Entities;
using Interfaces.Services;
using System.Globalization;
namespace interfaces {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string name = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy mm:HH): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy mm:HH): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double pricePerH = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double pricePerD = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(name));

            RentalService rentalService = new RentalService(pricePerH, pricePerD, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE");
            Console.WriteLine(carRental.Invoice);

        }
    }
}