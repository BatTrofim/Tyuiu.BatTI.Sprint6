using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BatTI.Sprint6.Task3.V6.Lib
{
    public class DataService : ISprint6Task3V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 2 && matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }   
}
