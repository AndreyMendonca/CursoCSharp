namespace Matrizes {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] vectot = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(vectot[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();
            int contagem = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] < 0) {
                        contagem++;
                    }
                }
            }
            Console.WriteLine("Número negativos: " + contagem);
        }
    }
}

