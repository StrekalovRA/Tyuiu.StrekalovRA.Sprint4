using Tyuiu.StrekalovRA.Sprint4.Task5.V18.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task5.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #4
                Тема: Двумерные массивы. (генератор случайных чисел)
                Задание #5
                Вариант #18
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными
                значениями в диапазоне от -6 до 7. Заменить отрицательные элементы на 0.
             */

            int[,] A = new int[5, 5] {
                { -1, 30, -1, 5, 1 },
                { 8, 4, -1, -4, 3 },
                { -3, 9, -2, 2, 5 },
                { 4, -6, 0, 5, -6 },
                { 1, 5, -2, 2, -5 }
            };

            DataService DS = new DataService();
            var Res = DS.Calculate(A);
            Console.WriteLine("РЕЗУЛЬТАТ: ");

            for (int I = 0; I < Res.GetLength(0); I += 1) {
                for (int J = 0; J < Res.GetLength(1); J += 1) { Console.Write(Res[I, J] + " "); }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
