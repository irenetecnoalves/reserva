using System; 
using Reserva.Entites;
using Reserva.Entites.Exceptions;

namespace Reserva
{
    class Program
    {
        static void Main(string[] args)
        {
          try
          {
            Console.Write("Room Number: ");
            int number= int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy):");
            DateTime checkIn= DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy):");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
         
             Reservesion reservesion = new Reservesion(number,checkIn,checkOut);
            Console.WriteLine("Reservation:"+reservesion);

            Console.WriteLine();
            Console.WriteLine("Enter data the reservation: ");
            Console.WriteLine("Checch-in date (dd/MM/yyyy):");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out data (dd/MM/yyyy): ");
            checkOut= DateTime.Parse(Console.ReadLine());

            reservesion.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Resservation: "+ reservesion);

           }
          catch(DomainException e)
           {
               Console.WriteLine("Error in reservation: "+ e.Message);
           }
           catch(FormatException e)
           {
               Console.WriteLine("Error in format: "+ e.Message);
           }
           catch(Exception e)
           {
               Console.WriteLine("Unexpected errorcl: "+ e.Message);
           }

        }
    }
}

