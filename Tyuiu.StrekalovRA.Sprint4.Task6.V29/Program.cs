using Tyuiu.StrekalovRA.Sprint4.Task6.V29.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #4
                Тема: Класс Array
                Задание #6
                Вариант #29
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Дан строковый массив данных ["Весна", "Лето", "Осень", "Зима"] используя класс Array
                подсчитайте количество элементов, длина которых больше 4.
             */

            string[] A = new string[4] { "Весна", "Лето", "Осень", "Зима" };
            DataService DS = new DataService();

            var Res = DS.Calculate(A);
            Console.WriteLine("РЕЗУЛЬТАТ: " + Res);
            Console.ReadKey();
        }
    }
}

57