using System;
using System.Collections.Generic;
using System.Text;

namespace EX01.Entitites.Enuns
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
