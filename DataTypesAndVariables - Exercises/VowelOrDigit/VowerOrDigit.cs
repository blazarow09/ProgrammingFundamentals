using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerHexToDecimal
{
    class hexToDecimal
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string toHexa = Convert.ToString(n, 16).ToUpper();
            string toBinary = Convert.ToString(n, 2).ToUpper();
            Console.WriteLine(toHexa);
            Console.WriteLine(toBinary);
        }
    }
}