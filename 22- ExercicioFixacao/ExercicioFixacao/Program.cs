using ExercicioFixacao.Entities;
using System.Globalization;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthday);

            Console.WriteLine("Enter order data:");

            Order order = new Order(DateTime.Now, OrderStatus.PROCESSING, client);


            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product prime: ");
                double price = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem oi = new OrderItem(quantity, price, new Product(name, price));

                order.AddItem(oi);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);


        }
    }
}