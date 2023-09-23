using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace SintaxeCsharpe {
    class Program {
        static void Main(string[] args) {
            int idade = 32;
            string nome = "Maria";
            double saldo = 2.30932039;
            Console.WriteLine(saldo.ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine($"{nome} tem {idade} e tem saldo igual a {saldo:F2} reais");

            //como fazer a leitura de dados
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            //lembrando, que podemos usar a mesma regra para convertes a string para o que estamos trabalhando

            int n2 = int.Parse(Console.ReadLine());
            int somaValor = soma(n1, n2);

            Console.WriteLine("Soma dos valores " + n1 + " + " + n2 + " = " + somaValor);

        }

        static int soma(int n1, int n2) {
            return n1+n2;
        }
    }
}
