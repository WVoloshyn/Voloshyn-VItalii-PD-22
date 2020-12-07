using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6 variant//
namespace lab1
{
    class  program
    {.
        static void Main(string[] args)
    {
        
            Console.WriteLine("Висота=");
                int high = Convert.ToInt32(Console.ReadLine()); ;
        Console.WriteLine("Радіус=");
                int radius = Convert.ToInt32(Console.ReadLine()); ;
            int V;
            V = pi * sqrt(radius) * high;
            Console.WriteLine(V);
        }
    }
}
