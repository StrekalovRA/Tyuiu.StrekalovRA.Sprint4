using Tyuiu.StrekalovRA.Sprint4.Task0.V14.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #4
                Тема: Одномерные массивы (статический ввод)
                Задание #0
                Вариант #14
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дан одномерный целочисленный массив на 10 элементов заполненный
                статическими значениями в диапазоне от 0 до 9 подсчитать сумму
                нечетных элементов массива.  {8, 9, 5, 4, 3, 2, 1, 0, 5, 7}
             */

            int[] Arr = new int[] { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.GetSumOddArrEl(Arr));
            Console.ReadKey();
        }
    }
}