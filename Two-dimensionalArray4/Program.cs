using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_dimensionalArray4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Козырсикй Илья 24 ис");
            int[,] mas = new int[3, 3]; // объявление двумерного массива
            int i, j; // объявление переменных
            for (i = 0; i < 3; i++)// по строкам
            {
                for (j = 0; j < 3; j++) // по строкам
                {
                    mas[i, j] = int.Parse(Console.ReadLine()); // ввод массива с клавиатуры
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (mas[i, j] > 0) //если элемента миссив больше 0 то 
                    {
                        double sqrmas = Math.Sqrt(mas[i, j]); // извлечение корней массива
                        Console.Write("{0:0.0}" + " ", sqrmas); // вывод на экран полученных значений 
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
