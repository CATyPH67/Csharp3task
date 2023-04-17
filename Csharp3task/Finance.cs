using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3task
{
    class Finance
    {
        protected double revenue;

        public Finance(double money)
        {
            revenue = money;
        }

        virtual public double calculate_tax()
        {
            return revenue;
        }
    }
}
