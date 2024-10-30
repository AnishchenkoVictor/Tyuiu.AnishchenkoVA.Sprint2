using Tyuiu.AnishchenkoVA.Sprint2.Task4.V30.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь вводит          *");
            Console.WriteLine("* значение x, y с клавиатуры, если x * 2 > y, то                          *");
            Console.WriteLine("*                 y                                                       *");
            Console.WriteLine("*     (      4   )                       2                                *");
            Console.WriteLine("* z = ( 6 +  -   )        иначе      y + -                                *");
            Console.WriteLine("*     (       2  )                        2                               *");
            Console.WriteLine("*     (      x   )                       x                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение выполнения функции = " + res);
            Console.ReadKey();
        }
    }
}
