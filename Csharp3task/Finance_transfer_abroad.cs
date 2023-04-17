﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3task
{
    class Finance_transfer_abroad : Finance
    {
        public Finance_transfer_abroad(double money)
            :base(money)
        {
        }

        public override double calculate_tax()
        {
            return revenue * 0.15;
        }
    }
}
