using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            DateTime dt = new DateTime (2000,1,1);
            for (int i = 0; i < 12; ++i)
            {
                
                Console.WriteLine(dt.AddMonths(i).ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")));
            }
            Console.ReadKey();
        }
    }
}
