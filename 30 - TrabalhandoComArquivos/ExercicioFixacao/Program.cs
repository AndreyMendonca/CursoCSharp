using ExercicioFixacao.Entities;
using System.Globalization;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\andre\Documents\FACULDADE\in.csv";
            string pathTarget = @"C:\Users\andre\Documents\FACULDADE\out.csv";

            List<Product> products = new List<Product>();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(line[2]);

                        products.Add(new Product(name, price, quantity));
                    }
                }
                using (StreamWriter sw = File.AppendText(pathTarget)) {
                    foreach(Product p in products) {
                        sw.WriteLine(p.Name + ", " + p.Amount());
                    }
                }
            } catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
