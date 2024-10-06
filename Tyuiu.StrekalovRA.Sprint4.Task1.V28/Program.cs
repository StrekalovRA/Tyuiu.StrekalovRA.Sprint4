using Tyuiu.StrekalovRA.Sprint4.Task1.V28.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #4
                Тема: Одномерные массивы. (ввод с клавиатуры)
                Задание #1
                Вариант #28
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дан одномерный целочисленный массив на 14 элементов заполненный значениями с
                клавиатуры в диапазоне от 2 до 6 подсчитать произведение нечетных элементов массива.
                С клавиатуры: 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4
             */

            Console.WriteLine("Целые числа через запятую:");
            bool Go_On = true;
            string A = Console.ReadLine();
            string[] B = new string[0];
            A = A.Replace(" ", "");

            try { B = A.Split(","); }
            catch (Exception ex) { Go_On = false; return; }

            if (Go_On) {
                int[] Nums = new int[0];
                Nums = new int[B.Length]; // массив целых чисел

                for (int I = 0; I < B.Length; I += 1) {
                    int C = int.Parse(B[I]);
                    Nums[I] = C;
                }

                DataService DS = new DataService();
                var R = DS.Calculate(Nums);
                Console.WriteLine("РЕЗУЛЬТАТ: " + R);
                Console.ReadKey();
            }
        }
    }
}