using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client client { get; set; }

        public List<OrderItem> items { get; set; } =  new List<OrderItem>();

        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client clinet) {
            this.Moment = moment;
            this.Status = status;
            this.client = clinet;
        }
        public void AddItem(OrderItem item) {
            items.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            items.Remove(item);
        }
        public double Total() {
            double total = 0.0;
            foreach (OrderItem i in items) {
                total += i.SubTotal();
            }
            return total;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine("Status " + Status);
            sb.AppendLine("Client " + client);
            sb.AppendLine("Order Items: ");
            foreach (OrderItem i in items) {
                sb.Append(i);
            }
            return sb.ToString();
        }
    }
}
