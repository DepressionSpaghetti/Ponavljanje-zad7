using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_zad7
{
    internal class Program
    {
        static bool Primarni(int broj)
        {
            if (broj == 1)
            {
                return false;
            }

            if (broj == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(broj)); ++i)
            {
                if (broj % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 0;i<100;i++)
            {
                if (Primarni(i)) sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
