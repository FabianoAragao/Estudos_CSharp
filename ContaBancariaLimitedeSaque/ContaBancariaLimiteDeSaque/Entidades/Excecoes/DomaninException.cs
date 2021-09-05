using System;

namespace ContaBancariaLimiteDeSaque.Entidades.Excecoes
{
    class DomaninException : ApplicationException
    {        public DomaninException(string message) : base(message)
        {
        }
    }
}
