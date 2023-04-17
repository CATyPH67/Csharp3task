using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3task
{
    class Finance_gift : Finance
    {
        public Finance_gift(double money)
            :base(money)
        {
        }

        public override double calculate_tax()
        {
            if (revenue < 4000)
            {
                return 0;
            }

            return revenue * 0.13;
        }
    }
}
