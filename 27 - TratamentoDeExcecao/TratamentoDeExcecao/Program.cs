using TratamentoDeExcecao.Entities;
using TratamentoDeExcecao.Entities.Exceptions;

namespace tratamento {
    class Program {
        static void Main(string[] strings) {
            
            try {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                DateTime checkout = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(number, checkin, checkout);

                Console.WriteLine(reservation);
            }catch(DomainException e) {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
