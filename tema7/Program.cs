using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 2, 8, 3 };
            int[] array2 = { 7, 1, 6, 4 };

            Console.WriteLine("Исходный массив 1: " + string.Join(", ", array1));
            Console.WriteLine("Исходный массив 2: " + string.Join(", ", array2));

            SortV(array1);
            Console.WriteLine("Массив 1 после сортировки по возрастанию: " + string.Join(", ", array1));

            SortU(array2);
            Console.WriteLine("Массив 2 после сортировки по убыванию: " + string.Join(", ", array2));

            int[] resultconc = conc(array1, array2);
            Console.WriteLine("Объединенный массив: " + string.Join(", ", resultconc));

            Console.Write("Введите целое число n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = ResultTask2(n);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }

            Console.Read();
        }

        public static void SortV(int[] arr)
        {
            Array.Sort(arr);
        }

        public static void SortU(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        public static int[] conc(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            Array.Copy(array1, mergedArray, array1.Length);
            Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);
            return mergedArray;
        }

        public static int ResultTask2(int n)
        {
            int res = Math.Abs(n - 123);

            if (n > 123)
            {
                return res * 3;
            }
            return res;
        }

    }
}
