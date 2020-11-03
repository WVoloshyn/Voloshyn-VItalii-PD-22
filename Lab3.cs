using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6. Перевірити істинність вислову: &quot;Дане ціле число є непарним тризначним числом&quot;. 

namespace lab3
{
    class Program
    {
        static void Main()
        {
            int number;
            string numString;

           try
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                numString = number.ToString();
                try
                {
                    if (numString.Length == 3)
                    {
                        if ((number % 2) == 0)
                        {
                            Console.WriteLine("False");
                        }
                        else
                        {
                            Console.WriteLine("true");
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are < than 3 digits!");

                    }
                }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
       
    }
}


