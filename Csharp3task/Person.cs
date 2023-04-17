using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3task
{
    class Person
    {
        private List<Finance> revenues;

        public Person(List<Finance> revenues)
        {
            this.revenues = revenues;
        }

        public List<double> calculate_tax()
        {
            List<double> taxes = new List<double>();
            foreach (Finance finance in revenues)
            {
                taxes.Add(finance.calculate_tax());
            }
            taxes.Sort();
            return taxes;
        }

    }
}
