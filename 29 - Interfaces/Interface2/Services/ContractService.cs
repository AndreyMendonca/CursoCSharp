using Interface2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2.Services {
    internal class ContractService {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {

            double amount = contract.TotalValue / months;

            for(int i = 1; i <= months; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double value = 0.0;
                value = _onlinePaymentService.Interest(amount, i);
                value = _onlinePaymentService.PaymentFee(value);
                contract.Installments.Add(new Installment(date, value));
            }
        }
    }
}
