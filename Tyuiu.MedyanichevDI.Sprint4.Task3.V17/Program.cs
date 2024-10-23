using Tyuiu.MedyanichevDI.Sprint4.Task3.V17.Lib;

namespace Tyuiu.MedyanichevDI.Sprint4.Task3.V17
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


            int[,] arr =  { { 6, 4, 2, 2, 1 },
                            { 3, 6, 5, 4, 1 },
                            { 5, 2, 3, 1, 6 },
                            { 8, 8, 4, 5, 3 },
                            { 7, 4, 5, 1, 6 } };

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
