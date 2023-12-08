using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Encapsulamento {
    class Conta {
        private int NumeroConta { get; }
        private string Nome { get; set; }
        private double Saldo { get; set; }

        public Conta( int numeroConta, string nome) {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome) {
            Saldo = depositoInicial;
        }

        public void Deposito(int quantidade) {
            Saldo += quantidade;
        }
        public void Saque(int quantidade) {
            Saldo -= (quantidade + 5.0);
        }

        public override string ToString() {
            return 
                "Conta " + NumeroConta 
                + ", Titular: " + Nome
                + ", Saldo: $" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
