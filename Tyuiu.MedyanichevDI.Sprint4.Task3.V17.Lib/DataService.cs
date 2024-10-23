using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MedyanichevDI.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            int row = array.GetUpperBound(0) + 1;
            int colum = array.Length / row;
            for (int i=0; i < row; i++)
            {
                for (int j=0; j<colum; j++)
                {
                    if (j == 3)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
