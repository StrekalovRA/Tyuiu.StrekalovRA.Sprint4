using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StrekalovRA.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] Arr)
        {
            int R = 1;
            foreach(int J in Arr) {
                if( J% 2 == 0) { R *= J; }
            }
            return R;
        }
    }
}
