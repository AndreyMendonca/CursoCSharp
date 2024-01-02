using _28___ExercicioTratamentoExcecao.Entities;
using _28___ExercicioTratamentoExcecao.Entities.Exception;
using System.Globalization;

namespace ex {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdraw);

                Console.WriteLine("Enter amount for withdraw:");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(value);

                Console.WriteLine("New Balance: " + acc.Balance);

            }
            catch(DomainException e) {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}
