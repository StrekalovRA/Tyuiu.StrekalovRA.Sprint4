using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StrekalovRA.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int X, int Y, string Str)
        {
            int Res = 1;
            for (int I = 0; I < X; I += 1) {
                for (int J = 0; J < Y; J += 1) {
                    Console.Write(Str[Y * I + J] + " ");
                    if (J == (Y - 1)) { Console.WriteLine(); }

                    int Digit = int.Parse(Str[Y * I + J].ToString());
                    if (Digit % 2 == 0) { Res *= Digit; }
                }
            }
            return Res;
        }
    }
}
