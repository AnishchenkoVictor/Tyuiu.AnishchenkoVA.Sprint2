using Tyuiu.AnishchenkoVA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,                 *");
            Console.WriteLine("* масти «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12,      *");
            Console.WriteLine("* «королю» — 13, «тузу» — 14 (порядковые номера карт остальных            *");
            Console.WriteLine("* достоинств соответствуют их названиям: «шестерка», «девятка» и т. п.).  *");
            Console.WriteLine("* По заданным номеру масти m (1 <= m <= 4) и                              *");
            Console.WriteLine("* номеру достоинства карты k (6 <= k <= 14)                               *");
            Console.WriteLine("* определить полное название (масть и достоинство) соответствующей карты  *");
            Console.WriteLine("* в виде «Дама пик», Шестерка бубен» и т. п.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер масти m (1 <= m <= 4):");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства k (6 <= k <= 14):");
            int x = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindCardNameAndValue(y, x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (((y < 1) || (y > 4)) && ((x < 6) || (x > 14)))
            {
                Console.WriteLine("Введенно не верное значение m и k");
            }
            else if ((x < 6) || (x > 14))
            {
                Console.WriteLine("Введенно не верное значение k");
            }
            else if ((y < 1) || (y > 4))
            {
                Console.WriteLine("Введенно не верное значение m");
            }
            else
            {
                Console.WriteLine("Ваша карта: " + ds.FindCardNameAndValue(x, y));
            }
            Console.ReadKey();
        }
    }
}
