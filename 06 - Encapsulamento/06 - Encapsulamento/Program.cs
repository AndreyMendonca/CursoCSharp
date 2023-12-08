
using _06___Encapsulamento;
using System.Globalization;
using System.Transactions;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n) ? ");
            char resposta = char.Parse(Console.ReadLine());

            Conta c;

            if (resposta == 's') {
                Console.Write("Digite o valor inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numeroConta, nome, valor);
            } else {
                c = new Conta(numeroConta, nome); 
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Valor de deposito: ");
            int deposito = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Valor do saque: ");
            int saque = int.Parse(Console.ReadLine());
            c.Saque(saque);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c);



        }
    }
}
