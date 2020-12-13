//Variant 6
using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk;
            do {
                Console.Write("Enter nn: ");
                nn = Convert.ToInt32(Console.ReadLine());
            } while (nn<0);
            do
            {
                Console.Write("Enter nk: ");
                nk = Convert.ToInt32(Console.ReadLine());
            } while (nk<nn);

            double product = 1;
            for (int k = nn; k <= nk; k++)
            {
                product = product * (Convert.ToInt32((Math.Pow((-1),k*k+1))*k*k-2)/3*k*k-2*k);
            }

            Console.WriteLine("Product = {0}", product);

        }
    }
}
