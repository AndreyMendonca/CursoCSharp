using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___ListExercicio {
    class Employees {
        public int Id { get; set; }
        private string Name { get; set; }
        private double Salary { get; set; }

        public Employees(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void UpdateSalary(double percent) {
            Salary = Salary + (Salary * (percent / 100.0));
        }

        public override string ToString() {
            return Id 
                + ", " + Name 
                + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
