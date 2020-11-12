using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1
{
    class Program
    {
        static int Check(ref string str)  //Проверка на десятичное число, замена точки на запятую
        {
            int num;

            if (!int.TryParse(str, out num))
            {
                Console.WriteLine("Необходимо ввести число! Конец программы.");
                Console.WriteLine("Для выхода нажмите любую кнопку...");
                Console.ReadKey();
                Environment.Exit(37707);
            }
            return num;
        }
        static void Main(string[] args)
        {
            {
                int[] arr = new int[1];
                Console.WriteLine("Введите количество элементов массива:");
                string str = Console.ReadLine();
                int N = Check(ref str);
                if (N <= 0)
                {
                    Console.WriteLine("Массива не существует");
                    Console.ReadKey();
                    Environment.Exit(404);
                }
                Array.Resize(ref arr, N);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Массив целочисленных чисел:");
                Random rnd = new Random();

                for (int i = 0; i < N; i++)
                {
                    arr[i] = rnd.Next(-10, 10);
                    Console.WriteLine("{0}", arr[i]);
                }
                Console.WriteLine();
                double min = Math.Abs(arr[0]);
                for (int i = 0; i < N; i++)
                    if (Math.Abs(arr[i]) <= Math.Abs(min))
                        min = arr[i];
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Минимальный по модулю элемент:  {0}", min);
                int x = 0;
                bool c = false;
                for (int i = 0; i < N; i++)
                    if (arr[i] == 0)
                    {
                        x = i;
                        c = true;
                        break;
                    }
                if (c)
                {
                    double sum = 0;
                    for (int i = x + 1; i < N; i++)
                        sum += arr[i];
                    Console.WriteLine("Сумма элементов расположенных после первого нулевого: {0}", sum);
                }
                else
                    Console.WriteLine("В массиве нет нулевых элементов.");

                int[] f = new int[N];
                for (int i = 0; i < N; i++)
                    f[i] = arr[i];
                int g = -1;
                for (int i = 0; i < N; i++)
                    if (i % 2 == 1)
                    {
                        g++;
                        arr[g] = f[i];
                    }
                for (int i = 0; i < N; i++)
                    if (i % 2 == 0)
                    {
                        g++;
                        arr[g] = f[i];
                    }
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Преобразованный массив: ");
                for (int i = 0; i < N; i++)
                    Console.WriteLine("{0}", arr[i]);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Для выхода нажмите любую кнопку...");
                Console.ReadKey();
            }
        }
    }
}

