using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_dimensionalArray5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[3, 3];
            int i, j, k = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                    if (mas[i, j] < 5 && mas[i, j] > 0) k++;
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(mas[i, j] + " ");// вывод массива
                }
                Console.WriteLine();
            }
            Console.WriteLine(" Количесвто элементов массива больше 0 , но меньше 5 = " + k);
            Console.ReadKey();

        }
    }
}
