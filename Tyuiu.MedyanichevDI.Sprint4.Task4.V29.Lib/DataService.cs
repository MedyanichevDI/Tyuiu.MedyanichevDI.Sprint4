using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MedyanichevDI.Sprint4.Task4.V29.Lib
{
    public class DataService : ISprint4Task4V29
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            int row = matrix.GetUpperBound(0) + 1;
            int colum = matrix.Length / row;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    if (matrix[i,j]%2== 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
