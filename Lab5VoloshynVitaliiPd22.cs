using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// lab 5
//11.	Дана матриця розміру m * n. Знайти 1) мінімальне; 2) максимальне
//значення серед сум елементів всіх її рядків (стовпчиків) і номер
//рядка (стовпчика) з цим мінімальним або |максимальним значенням.
namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("To create a matrix, enter m and n");
            Console.Write("m: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n: ");
            n = Convert.ToInt32(Console.ReadLine());

            //creating the matrix
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("matrix[{0}][{1}] = ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //display the matrix
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            int max = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                    if (sum > max)
                    {
                        max = sum;
                    }
                  


                }
                Console.Write("Sum of lines:");
                Console.WriteLine(sum + " ");



            }
            Console.Write("max of lines:");
            Console.WriteLine(max);
            int min = int.MaxValue;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {

                int sum = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];

                    if (min >sum)
                    {
                        min = sum;
                    }



                }
            }Console.Write("Min of lines:");
                    Console.WriteLine(min-1);

          
            int maxR = 0;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {

                        int sumR = 0;
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            sumR += matrix[j, i];
                            if (sumR > maxR)
                            {
                                maxR = sumR;
                            }
                        }
                        Console.Write("Sum of rows:");
                        Console.WriteLine(sumR + " ");


                    }
                    Console.Write("Max of rows:");
                    Console.WriteLine(maxR);

            int minR = int.MaxValue;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {

                int sum = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];

                    if (min > sum)
                    {
                        min = sum;
                    }



                }
            }
            Console.Write("Min of rows:");
            Console.WriteLine(min - 1);



        }
            }
        }
 
