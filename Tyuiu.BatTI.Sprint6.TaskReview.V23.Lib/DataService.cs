using System.Reflection.Metadata.Ecma335;

namespace Tyuiu.BatTI.Sprint6.TaskReview.V23.Lib
{
    public class DataService
    {
        Random random = new Random();
        public int[,] GetMatrix(int n, int m, int n1, int n2)
        {
            Random rnd = new Random();
            int[,] array = new int[n, m];
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 0)
                    {
                        array[i, j] = rnd.Next(n1, n2);
                    }
                    else
                    {
                        array[i, j] = (int)Math.Pow(Convert.ToInt32(array[i, j - 1]), 2);
                    }
                }
            }
            return array;
        }
        public int resultGetMatrix(int[,] array, int r, int k, int l)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int res = 1;
            for (int j = k - 1; j < l; j++)
            {
                if (array[r - 1, j] % 2 == 0)
                {
                    res = res * array[r - 1, j];
                }
            }
            return res;
        }
    }
}
