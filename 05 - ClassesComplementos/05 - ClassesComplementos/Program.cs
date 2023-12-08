using _05___ClassesComplementos;
using System;
using System.Globalization;

namespace Classe {
    class Program {
        static void Main(string[] args) {

            Produto p;

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());
            
            p = new Produto(Nome, Preco, Quantidade);

            Console.WriteLine("Ddos do produto: " + p);
        }
    }
}
