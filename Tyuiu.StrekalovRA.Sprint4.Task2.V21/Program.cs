using Tyuiu.StrekalovRA.Sprint4.Task2.V21.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #4
                Тема: Одномерные массивы. (генератор случайных чисел)
                Задание #2
                Вариант #21
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дан одномерный целочисленный массив на 15 элементов заполненный
                случайными в диапазоне от 1 до 7 подсчитать произведение четных элементов массива.
             */

            int[] A = new int[] { 1, 2, 6, 4, 7, 4, 3 };
            DataService DS = new DataService();
            var R = DS.Calculate(A);
            Console.WriteLine("РЕЗУЛЬТАТ: " + R);
            Console.ReadKey();
        }
    }
}