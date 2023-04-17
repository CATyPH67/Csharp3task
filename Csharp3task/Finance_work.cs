using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3task
{
    class Finance_work : Finance
    {
        public Finance_work(int money) 
            :base(money)
        {
        }

        public override double calculate_tax()
        {
            return revenue * 0.3;
        }
    }
}
