﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MedyanichevDI.Sprint4.Task1.V6.Lib
{
    public class DataService : ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int cal = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0)
                {
                    cal *= array[i];
                }
            }
            return cal;
        }
    }
}
