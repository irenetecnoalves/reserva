using System;

namespace Reserva.Entites.Exceptions
{
    public class DomainException: ApplicationException

    {
        public DomainException(string message): base (message)
        {

        }
        
    }
}