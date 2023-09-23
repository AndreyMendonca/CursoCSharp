using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(x > 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo!!!");

            Console.WriteLine("Digite um numero para ser impresso a contagem até 0: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i = numero; i >= 0; i--) {
                Console.WriteLine(i.ToString());
            }
        }
    }
}