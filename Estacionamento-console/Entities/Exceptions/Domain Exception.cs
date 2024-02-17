using System;
using System.Collections.Generic;


namespace Estacionamento_console.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message):base(message) { 
        }
    }
}
