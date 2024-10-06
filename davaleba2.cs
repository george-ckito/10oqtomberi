using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10oqtomberi
{
    internal class Davaleba2
    {
        public void Execute()
        {
            double num;
            Console.WriteLine("Enter your number:");
            num = Convert.ToDouble(Console.ReadLine());
            int mteli = Convert.ToInt32(num);
            if (mteli < 0) {
                mteli++;
            }
            Console.WriteLine($"Answer: {num - mteli}");
            if ((num - mteli) == 0) {
                Console.WriteLine("savaraudod mdzime daweret wertilis magivrad (naxevari saati ver vugebdi nuli rato iyo)");
            }
        }
    }
}
