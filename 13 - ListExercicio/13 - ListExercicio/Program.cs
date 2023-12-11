using _13___ListExercicio;
using System.Collections.Generic;
using System.Globalization;

namespace list {
    class Program {
        static void Main(string[] args) {
            List<Employees> list = new List<Employees>();

            Console.Write("How many employees will be registered?  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Employee " + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employees(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int ids = int.Parse(Console.ReadLine());

            Employees e = list.Find(x => x.Id == ids);

            if (e == null) {
                Console.WriteLine("This id does not exist!!!");
            } else {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e.UpdateSalary(percent);
            }

            foreach(Employees obj  in list) {
                Console.WriteLine(obj);
            }
  

        }
    }
}
