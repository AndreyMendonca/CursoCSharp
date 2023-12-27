using Heranca.Entities;

namespace Heranca {
    class Program {
        static void Main(string[] args) {
            Account acc1 = new(1, "Joao", 500.00);
            BusinessAccount acc2 = new BusinessAccount(2, "Maria", 0.0, 100);
            SavingsAccount acc3 = new SavingsAccount(3, "Carlos", 500.00, 1);

            // Toda classs filha pode ser uma classe mae

            acc1.Withdraw(100);
            acc3.Withdraw(100);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);    

        }
    }
}
