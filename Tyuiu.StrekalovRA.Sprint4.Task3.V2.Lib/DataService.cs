using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StrekalovRA.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] Arr)
        {
            int[] First_ = new int[5];

            for (int I = 0; I < Arr.GetLength(1); I += 1) {
                First_[I] = Arr[0, I];
            }
            return First_.Max();
        }
    }
}
