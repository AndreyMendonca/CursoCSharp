using _05___ClassesComplementos;
using System;
using System.Globalization;

namespace Classe {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Ddos do produto: " + p);
        }
    }
}
