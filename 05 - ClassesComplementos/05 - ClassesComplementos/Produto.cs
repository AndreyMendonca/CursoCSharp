using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05___ClassesComplementos {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarEstoque(int quantidade) {
            this.Quantidade += quantidade;
        }
        public void RemoverEstoque(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + " $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " Quantidade: " + Quantidade
                + " Valor total em estoque: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
