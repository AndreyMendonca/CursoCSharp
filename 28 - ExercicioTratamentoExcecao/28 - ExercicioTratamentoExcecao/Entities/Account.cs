using _28___ExercicioTratamentoExcecao.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _28___ExercicioTratamentoExcecao.Entities {
    internal class Account {
        public int Number {  get; set; }
        public string Holder { get; set; }
        public double Balance {  get; set; }
        public double Limit {  get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double limit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            Limit = limit;
        }
        public void Deposit(double value){
            Balance += value;
        }
        public void Withdraw(double value) {
            if (value >= Balance) {
                throw new DomainException("Erro, valor maior que saldo");
            }
            if(value >= Limit) {
                throw new DomainException("Erro, valor maior que limit");
            }
            Balance -= value;
        }
    }
}
