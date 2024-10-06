using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10oqtomberi
{
    internal class Davaleba5
    {
        public void Execute()
        {
            Console.WriteLine("Enter your first boolean");
            bool a = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter your second boolean");
            bool b = Convert.ToBoolean(Console.ReadLine());
            if(a != b)
            {
                a = !a;
                b = !b;
            }
            Console.WriteLine($"Switched booleans! First - {a}, Second - {b}");
        }
    }
}
