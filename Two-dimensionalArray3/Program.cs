using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_dimensionalArray3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работу выполнил ученик группы 24ис Козырский Илья");
            int[,] Mas = new int[3, 3]; // объявление двумерного массива
            int i, j, k = 0; // объявление переменных
            for (i = 0; i < 3; i++) // по строкам
            {
                for (j = 0; j < 3; j++)//по столбцам
                {
                    Mas[i, j] = int.Parse(Console.ReadLine()); // ввод массива с клавиатуры
                    if (Mas[i, j] > 5) k++; // количество  элементов массива больших 5, за каждый элемент увеличивается на 1 
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(Mas[i, j] + " ");// вывод массива
                }
                Console.WriteLine(); // вывод элементов массива в виде матрицы
            }
            Console.WriteLine(" Количество  элементов массива больше 5 " + k); // вывод количество отрицательных элементов массива
            Console.ReadKey();

        }
    }
}
