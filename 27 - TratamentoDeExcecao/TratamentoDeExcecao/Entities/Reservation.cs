using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoDeExcecao.Entities.Exceptions;

namespace TratamentoDeExcecao.Entities {
    class Reservation {
        public int RoomNumber {  get; set; }
        public DateTime Checkin {  get; set; }
        public DateTime Checkout {  get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout) {

            if(checkin >= checkout) {
                throw new DomainException("Check-out date must be after check-in date!");
            }
            
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration() {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void updateDates(DateTime checkin, DateTime checkout) {
            DateTime now = DateTime.Now;
            if(checkin < now || checkout < now) {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkin >= checkout) {
                throw new DomainException("Check-out date must be after check-in date!");
            }
            Checkin = checkin;
            Checkout = checkout;
        }
        public override string ToString() {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
