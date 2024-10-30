using Tyuiu.AnishchenkoVA.Sprint2.Task5.V2.Lib;
using System.Security.Cryptography.X509Certificates;

namespace Tyuiu.AnishchenkoVA.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По данному месяцу, определите в какую пору года                         *");
            Console.WriteLine("* попадает этот месяц (Зима, Лето, Весна, Осень).                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца:");
            int x = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((x < 1) ||  (x > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Этот месяц попадает в эту пору года: " + ds.FindMonthSeason(x);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
