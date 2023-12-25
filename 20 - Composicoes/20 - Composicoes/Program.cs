using _20___Composicoes.Entities;
using _20___Composicoes.Entities.Enums;
using System.Globalization;
using System.Transactions;

namespace composicoes {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter department's name: ");
            string nameDepartament = Console.ReadLine();
            Department department = new Department(nameDepartament);

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Worker worker = new Worker(name, WorkerLevel.MidLevel, salary, department);

            Console.Write("How many contracts to this worker? ");
            int aux = int.Parse(Console.ReadLine());

            for (int i = 0; i < aux; i++) {
                Console.WriteLine("Enter #" + i+1 + "contract date: ");
                Console.Write("Date (DD/MM/YYYY");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                int hours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, valuePerHour, hours));
            }

            Console.WriteLine();
            Console.Write("EEnter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year,month));

        }
    }
}
