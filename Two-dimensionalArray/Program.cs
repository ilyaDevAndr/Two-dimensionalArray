using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_dimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Работу выполнил ученик группы 24ИС Козырский Илья");
            int[,] Mas = new int[3, 3];//объявление массива 
            int i, j, k = 0;// объявление переменных
            for (i = 0; i < 3; i++) // по строкам
            {
                for (j = 0; j < 3; j++) // по столбцам 
                {
                    Mas[i, j] = int.Parse(Console.ReadLine()); // ввод с клавиатуры
                    if (Mas[i, j] != 0) k++; // условие при котором, массив неравный 0 , увеличивает количество ненулевых массивов на 1 , начиная с нуля
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(Mas[i, j] + " "); // вывод на экран элементов массива

                }
                Console.WriteLine();// вывод значений в виде матрицы
            }
            Console.WriteLine("Колличество ненулевых элементов " + k);

            Console.ReadKey();

        }
    }
}
