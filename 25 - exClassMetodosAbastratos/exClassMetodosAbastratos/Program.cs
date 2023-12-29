using exClassMetodosAbastratos.Entities;
using System.Globalization;

namespace program {
    class Program {
        static void Main(string[] args) {
            Console.Write(" Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine()) ;

            for(int i = 1; i <= n ; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char r = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                TaxPayer t;

                if(r == 'i') {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    t = new Individual(health, name, income);
                } else {
                    Console.Write("Number of employees:: ");
                    int employess = int.Parse(Console.ReadLine());
                    t = new Company(employess, name, income);
                }

                Console.WriteLine(t.Tax());

            }
        }
    }
}
