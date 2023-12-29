using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoEHerança.Entities {
    class ImportedProduct : Product{
        public double CustomsFee;
        public ImportedProduct(double customsFee, string name, double price) : base(name, price) {

        }

        public override string PriceTag() {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " ( Customs Fee : $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
