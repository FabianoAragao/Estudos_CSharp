using System;

namespace ReservaHotel.Entidades.Excecoes
{
    class DomaninException : ApplicationException
    {
        public DomaninException(string message) : base(message)
        {
        }
    }
}
