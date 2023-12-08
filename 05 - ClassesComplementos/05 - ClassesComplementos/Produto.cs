using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05___ClassesComplementos {
    class Produto {
        private string _nome;
        private double Preco { get; set; }
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        public string getNome() {
            return _nome;
        }
        public void setNome(string nome) {
            _nome = nome;
        }

        public double ValorTotalEmEstoque() {
            return Preco * _quantidade;
        }
        public void AdicionarEstoque(int quantidade) {
            this._quantidade += quantidade;
        }
        public void RemoverEstoque(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
                + " $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " Quantidade: " + _quantidade
                + " Valor total em estoque: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
