using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entities.Exception
{
    class WithdrawException:ApplicationException
    {
        public WithdrawException(string message):base(message)
        {

        }
    }
}
