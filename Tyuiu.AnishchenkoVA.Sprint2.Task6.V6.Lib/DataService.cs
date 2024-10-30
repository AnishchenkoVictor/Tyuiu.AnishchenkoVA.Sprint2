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
                case 6: res1 = "шестерка"; break;
                case 7: res1 = "семерка"; break;
                case 8: res1 = "восьмерка"; break;
                case 9: res1 = "девятка"; break;
                case 10: res1 = "десятка"; break;
                case 11: res1 = "валет"; break;
                case 12: res1 = "дама"; break;
                case 13: res1 = "король"; break;
                case 14: res1 = "туз"; break;

            }

            string res2 = "";
            switch (value2)
            {
                case 1: res2 = "пик"; break;
                case 2: res2 = "треф"; break;
                case 3: res2 = "бубен"; break;
                case 4: res2 = "черв"; break;
            }

            string res = res1 + " " + res2;
            return res;

        }
    }
}
