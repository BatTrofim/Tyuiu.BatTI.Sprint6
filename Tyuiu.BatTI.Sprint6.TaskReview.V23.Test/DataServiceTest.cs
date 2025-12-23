using Tyuiu.BatTI.Sprint6.TaskReview.V23.Lib;

namespace Tyuiu.BatTI.Sprint6.TaskReview.V23.Test
{  
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random rand = new Random();
            DataService ds = new DataService();
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int[,] wait = new int[n, m];
            int[,] res = ds.GetMatrix(n, m, n1, n2);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 0)
                    {
                        wait[i, j] = rand.Next(n1, n2);
                    }
                    else
                    {
                        wait[i, j] = (int)Math.Pow(Convert.ToInt32(wait[i, j - 1]), 2);
                    }
                }
            }
            Assert.AreEqual(wait, res);
        }
    }
}
