using _06_HashComparandoIgualdade.Entities;

namespace hash {
    class Program {
        static void Main(string[] args) {
            HashSet<Product> prod = new HashSet<Product>();

            prod.Add(new Product("Computador", 100.0));

            Product a = new Product("Computador", 100.0);

            Console.WriteLine(prod.Contains(a));

         }
    }
}