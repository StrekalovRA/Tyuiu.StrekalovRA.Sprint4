using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StrekalovRA.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] Arr)
        {
            int R = 1;
            foreach(int J in Arr) {
                if (J >= 2 && J <= 6 && (J % 2 != 0)) {R *= J; }
            }
            return R;
        }
    }
}
