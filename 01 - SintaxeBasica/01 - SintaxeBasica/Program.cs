using System;
using System.Globalization;

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


        }
    }
}
