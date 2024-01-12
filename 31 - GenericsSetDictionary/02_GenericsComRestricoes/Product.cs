using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GenericsComRestricoes {
    internal class Product : IComparable{
        public string Name {  get; set; }
        public double Value { get; set; }
        
        public Product(string name, double value) {
            Name = name;
            Value = value;
        }

        public override string ToString() {
            return Name + " " + Value;
        }

        public int CompareTo(object obj) {
            if(!(obj is Product)) {
                throw new ArgumentException("Erro!");
            }
            Product other = obj as Product;
            return Value.CompareTo(other.Value);
        }
    }
}
