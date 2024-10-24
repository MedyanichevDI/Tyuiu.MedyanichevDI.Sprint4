using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MedyanichevDI.Sprint4.Task7.V9.Lib
{
    public class DataService : ISprint4Task7V9
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] arr = new int[n,m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(value.Substring(i * n + j, 1));

                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
    }
}
