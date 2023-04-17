using System;
using System.Collections.Generic;

namespace Csharp3task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Finance> revenues = new List<Finance>();
            revenues.Add(new Finance_work(100000));
            revenues.Add(new Award(1000));
            revenues.Add(new Finance_children_benefits(10000));
            revenues.Add(new Finance_gift(1000));
            revenues.Add(new Finance_sale(50000));
            revenues.Add(new Finance_transfer_abroad(2000));
            revenues.Add(new Financial_assistance(4000));

            Person oleg = new Person(revenues);
            List<double> taxes = oleg.calculate_tax();
            taxes.ForEach(Console.WriteLine);


        }
    }
}
