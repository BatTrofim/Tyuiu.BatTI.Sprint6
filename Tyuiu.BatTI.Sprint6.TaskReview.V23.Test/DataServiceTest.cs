using Tyuiu.BatTI.Sprint6.TaskReview.V23.Lib;

namespace Tyuiu.BatTI.Sprint6.TaskReview.V23.Test
{  
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { {8, 64, 3, 9, 10 },
                                            { 7, 49, 1, 1, 9 },
                                            { 0, 0, 4, 16, 8 },
                                            { 5, 25, 2, 4, 9 },
                                            { 3, 9, 0, 0, 1 } };

            int res = ds.resultGetMatrix(array, 3, 1, 4);
            int wait = 64;
        }
    }
}
