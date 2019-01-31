using System;
using System.Collections.Generic;
using System.Text;

namespace CapEnum.Entities.Enum
{
    enum OrderEnum : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
