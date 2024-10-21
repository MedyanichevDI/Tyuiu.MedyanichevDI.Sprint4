using Tyuiu.MedyanichevDI.Sprint4.Task2.V8.Lib;

namespace Tyuiu.MedyanichevDI.Sprint4.Task2.V8
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("Дан одномерный целочисленный массив на 10 элементов заполненный           *");

            Console.WriteLine("*статическими значениями в диапазоне от 0 до 9                            *");
            Console.WriteLine("*подсчитать произведение нечетных элементов массива.                      *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");
            Random rnd = new Random();
            int len = 11;
            int[] arr = new int[len];
            for (int i=0; i <= len; i++)
            {
                arr[i] = rnd.Next(2, 7);
            }
            for (int i = 0; i < len-1; i++)
            {
                Console.WriteLine(arr[i] + "/t");    
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(arr));
        }
    }
}
