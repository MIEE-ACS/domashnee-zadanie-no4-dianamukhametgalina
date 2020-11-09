using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Целочисленная матрица размером 10х10:");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Random rnd = new Random();
            int[,] Array = new int[10, 10];

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Array[y, x] = rnd.Next(-100, 100);
                }
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(Array[y, x] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    sum += Math.Abs(Array[i, j]);
                }
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Сумма модулей элементов, расположенных выше главной диагонали: {0}", sum);

            int Localmin = 0;
            for (int i = 1; i < Array.GetLength(0) - 1; i++)
                for (int j = 1; j < Array.GetLength(1) - 1; j++)
                {
                    if ((Array[i, j] < Array[i - 1, j - 1])
                    && (Array[i, j] < Array[i - 1, j])
                    && (Array[i, j] < Array[i - 1, j + 1])
                    && (Array[i, j] < Array[i, j - 1])
                    && (Array[i, j] < Array[i, j + 1])
                    && (Array[i, j] < Array[i + 1, j - 1])
                    && (Array[i, j] < Array[i + 1, j])
                    && (Array[i, j] < Array[i + 1, j + 1]))
                    {
                        Localmin++;
                    }

                }
            Console.WriteLine(" ");
            Console.WriteLine("Количество локальных минимумов на заданной матрице: " + Localmin);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Для выхода нажмите любую кнопку...");
            Console.ReadKey();
        }
    }

}

