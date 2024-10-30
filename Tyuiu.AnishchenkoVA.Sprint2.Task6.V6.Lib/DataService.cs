using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res1 = "";
            switch (value1)
            {
                case 6: 
                    res1 = "Шестерка"; break;
                case 7: 
                    res1 = "Семерка"; break;
                case 8: 
                    res1 = "Восьмерка"; break;
                case 9: 
                    res1 = "Девятка"; break;
                case 10: 
                    res1 = "Десятка"; break;
                case 11: 
                    res1 = "Валет"; break;
                case 12: 
                    res1 = "Дама"; break;
                case 13: 
                    res1 = "Король"; break;
                case 14: 
                    res1 = "Туз"; break;

            }

            string res2 = "";
            switch (value2)
            {
                case 1: 
                    res2 = "пик"; break;
                case 2: 
                    res2 = "треф"; break;
                case 3: 
                    res2 = "бубн"; break;
                case 4: 
                    res2 = "черв"; break;
            }

            string res = res1 + " " + res2;
            return res;

        }
    }
}
