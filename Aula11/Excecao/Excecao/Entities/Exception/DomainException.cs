using System;

namespace Excecao.Entities.Exception
{
    class DomainException:ApplicationException
    {
        public DomainException(string message):base(message)
        {

        }
    }
}
