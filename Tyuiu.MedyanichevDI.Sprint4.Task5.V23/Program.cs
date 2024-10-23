using Tyuiu.MedyanichevDI.Sprint4.Task5.V23.Lib;

namespace Tyuiu.MedyanichevDI.Sprint4.Task5.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный          *");

            Console.WriteLine("*в четвертом столбце массива.   *");
            //Console.WriteLine("*подсчитать произведение нечетных элементов массива.                      *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");
            Random rnd = new Random();
            int[,] arr = new int[5, 5];
            for (int i =0; i < arr.GetUpperBound(0)+1;i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; i++)
                {
                    arr[i, j] = rnd.Next(-4, 8);
                }
            }

            
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; i++)
                {
                    Console.WriteLine(arr[i, j] + "/t");
                }

            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(arr));
        }
    }
}
