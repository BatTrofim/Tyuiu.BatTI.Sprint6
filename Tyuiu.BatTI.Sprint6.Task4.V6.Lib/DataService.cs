using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BatTI.Sprint6.Task4.V6.Lib
{
    public class DataService : ISprint6Task4V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int k = 0;
            for (int x = startValue; x < stopValue + 1; x++)
            {
                if ((3 * x - 1) != 0)
                {
                    res[k] = Math.Round((3 * Math.Cos(x)) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2, 2);
                    k++;
                }
                else { res[k] = 0; k++; }
            }
            return res;
        }
    }
}
