
using _05___ClassesExercicio;

namespace Class {
    class Program {
        static void Main(string[] args) {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade");
            pessoa1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da Segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine(pessoa1.Nome + " É MAIS VELHA");
            } else {
                Console.WriteLine(pessoa2.Nome + " É MAIS VELHA");
            }
        }
    }

}
