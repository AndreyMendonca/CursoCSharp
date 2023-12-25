using _19___Enum.Entities;
using _19___Enum.Entities.Enums;

namespace Enum {
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };
            Console.WriteLine(order);

            //Convertendo Enum em string
            string txt = OrderStatus.Processing.ToString();

            Console.WriteLine(txt);

        }
    }
}
