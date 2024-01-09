using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2.Services {
    internal class PaypalService : IOnlinePaymentService {
        public double Interest(double amount, int months) {
            double final = 0.0;
            final = (amount * 0.01) * months;
            final += amount;
            return final;
        }

        public double PaymentFee(double amount) {
            return (amount * 0.02) + amount;
        }
    }
}
