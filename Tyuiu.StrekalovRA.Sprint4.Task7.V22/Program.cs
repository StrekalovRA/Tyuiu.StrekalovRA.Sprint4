using Tyuiu.StrekalovRA.Sprint4.Task7.V22.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #4
                Тема: Добавление к решению итоговых проектов по спринту
                Задание #7
                Вариант #22
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дана строка из одноразрядных цифр "695324951753684". Преобразуйте ее в
                матрицу 5 на 3 и подсчитайте произведение четных чисел.
             */

            int Amount_Cols = 5; // длина по X или количество столбцов
            int Elems_Per_Col = 3; // длина по Y или количество строк
            string Str = "695324951753684";

            DataService DS = new DataService();
            var Res = DS.Calculate(Amount_Cols, Elems_Per_Col, Str);
            Console.WriteLine("РЕЗУЛЬТАТ: " + Res);
            Console.ReadKey();
        }
    }
}