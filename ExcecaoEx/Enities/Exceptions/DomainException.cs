using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecaoEx.Enities.Exceptions
{
    //SESSÃO PERSONALIZADA
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
