
namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite 3 valores: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior valor: " + resultado);
        }

        static int Maior(int n1, int n2, int n3) {
            int resultado;

            if(n1 > n2 & n1 > n3) {
                resultado = n1;
            }else if (n2 > n3) {
                resultado = n2;
            } else {
                resultado = n3;
            }

            return resultado;
        }
    }
}
