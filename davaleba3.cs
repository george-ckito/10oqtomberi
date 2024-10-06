using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10oqtomberi
{
    internal class Davaleba3
    {
        public void Execute() {
            Console.WriteLine("Enter your number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 99 && num < 1000)
            {
                Console.WriteLine("Your number has 3 digits");
            } else
            {
                Console.WriteLine("Your number doesn't have 3 digits");
            }
        }
    }
}
