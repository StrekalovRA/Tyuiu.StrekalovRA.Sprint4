using Tyuiu.StrekalovRA.Sprint4.Task3.V2.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #4
                Тема: Двумерные массивы. (статический ввод)
                Задание #3
                Вариант #2
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими
                значениями в диапазоне от 2 до 8. Найдите максимальный элемент в первой строке массива.
             */

            int[,] A = new int[4, 5] {
                { 4, 6, 5, 5, 7 }, { 3, 8, 8, 3, 5 },
                { 5, 7, 5, 4, 4 }, { 8, 8, 3, 7, 6 }
            };

            DataService DS = new DataService();
            var R = DS.Calculate(A);
            Console.WriteLine("РЕЗУЛЬТАТ: " + R);
            Console.ReadKey();
        }
    }
}