using System;
using System.Runtime.Remoting.Messaging;

namespace justForFun
{
    class MainClass
    {
        public static void Main()
            //6. Поміняти місцями мінімальний і максимальний елементи масиву розміру N.
        {
            int imax = 0;
            int imin = 0;
            int[] a = new int[20];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write((a[i] = r.Next(0, 99)) + " ");
                if (a[imin] > a[i])
                {
                    imin = i;
                }
                if (a[imax] < a[i])
                {
                    imax = i;
                }
            }

            int x = a[imin];
            a[imin] = a[imax];
            a[imax] = x;

            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");

          
        }

    }
 }
 
