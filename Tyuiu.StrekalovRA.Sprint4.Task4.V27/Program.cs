using Tyuiu.StrekalovRA.Sprint4.Task4.V27.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #4
                Тема: Двумерные массивы. (ввод с клавиатуры)
                Задание #4
                Вариант #27
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с
                клавиатуры в диапазоне от 1 до 9. Найдите сумму нечетных элементов массива.
                4, 3, 9, 2, 2,
                8, 4, 1, 4, 3,
                3, 9, 2, 2, 5,
                4, 6, 8, 5, 6,
                1, 5, 2, 2, 5,
             */

            int[,] A = new int[5, 5] {
                { 4, 3, 9, 2, 2 },
                { 8, 4, 1, 4, 3 },
                { 3, 9, 2, 2, 5 },
                { 4, 6, 8, 5, 6 },
                { 1, 5, 2, 2, 5 }
            };

            DataService DS = new DataService();
            var Res = DS.Calculate(A);
            Console.WriteLine("РЕЗУЛЬТАТ: " + Res);
            Console.ReadKey();
        }
    }
}