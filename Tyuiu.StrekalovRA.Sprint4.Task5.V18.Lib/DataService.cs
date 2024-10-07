using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StrekalovRA.Sprint4.Task5.V18.Lib
{
    public class DataService : ISprint4Task5V18
    {
        public int[,] Calculate(int[,] M)
        {
            for (int I = 0; I < M.GetLength(0); I += 1) {
                for (int J = 0; J < M.GetLength(1); J += 1) {
                    if (M[I, J] < 0) { M[I, J] = 0; }
                }
            }
            return M;
        }
    }
}
