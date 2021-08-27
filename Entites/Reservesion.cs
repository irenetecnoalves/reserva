using System;
using Reserva.Entites.Exceptions;

namespace Reserva.Entites
{
    public class Reservesion
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservesion(){}

        public Reservesion(int roomNumber,DateTime checkIn,DateTime checkOut)

        {

            if (checkOut <= checkIn)
             { throw new DomainException ("Check-out must be affter check-in ");}

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration ()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; //diferenca em dias na reserva
         }

         public void UpdateDates(DateTime checkIn,DateTime checkOut)
         {
             DateTime now = DateTime.Now;
             if (checkIn < now || checkOut < now)
             { throw new DomainException("Reservation date for update must be future dates");
             }
            
             else if (checkOut <= checkIn)
             { throw new DomainException ("Check-out must be affter check-in ");
             }

             CheckIn= checkIn;
             CheckOut= checkOut;
         }

        public override string ToString()
        {
            return "Room "+ RoomNumber+",Check-in: "+CheckIn.ToString("dd/MM/yyyy")
            +",Check-out: "+CheckOut.ToString("dd/MM/yyyy")+","+Duration()+"nights";
        }
    }
}