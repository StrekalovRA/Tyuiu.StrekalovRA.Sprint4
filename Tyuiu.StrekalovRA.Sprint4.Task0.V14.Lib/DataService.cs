using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StrekalovRA.Sprint4.Task0.V14.Lib
{
    public class DataService : ISprint4Task0V14
    {
        public int GetSumOddArrEl(int[] Arr)
        {
            int Res = 0;
            foreach(int J in Arr) {
                if (J % 2 != 0) Res += J;
            }
            return Res;
        }
    }
}
