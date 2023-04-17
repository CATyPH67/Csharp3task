using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3task
{
    class Financial_assistance : Finance
    {
        public Financial_assistance(double money)
            : base(money)
        {
        }

        public override double calculate_tax()
        {
            return revenue * 0.1;
        }
    }
}
