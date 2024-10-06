using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10oqtomberi
{
    internal class Davaleba1
    {
        public void Execute() {
            int a, b;
            bool withoutAdd;
            Console.WriteLine("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Without additional variable? y/n");
            withoutAdd = Console.ReadLine() == "y";
            if (withoutAdd)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            else
            {
                int c;
                c = a;
                a = b;
                b = c;
            };
            Console.WriteLine($"Ints Switched: a = {a}; b = {b}");
        }
    }
}
