using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exClassMetodosAbastratos.Entities {
    class Company : TaxPayer{
        public int NumberOfEmployes { get; set; }

        public Company(int numberOfEmployes, string name, double anualIncome) : base(name, anualIncome) {
            NumberOfEmployes = numberOfEmployes;
        }
        public override double Tax() {
            if(NumberOfEmployes < 10) {
                return AnualIncome * 0.16;
            }else{
                return AnualIncome * 0.14;
            }
        }
    }
}
