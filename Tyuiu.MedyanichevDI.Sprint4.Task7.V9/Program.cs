using Tyuiu.MedyanichevDI.Sprint4.Task7.V9.Lib;

namespace Tyuiu.MedyanichevDI.Sprint4.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
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
            int i = 3;
            int j = 3;
            string num = "864299753";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(i,j,num));
        }
    }
}
