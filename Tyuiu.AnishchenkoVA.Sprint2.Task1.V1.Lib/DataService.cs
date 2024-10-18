using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (b < d);
            res[1] = (a > b) & (b < a);
            res[2] = (a > b) || (b < d);
            res[3] = (a > b) && (b < a);
            res[4] = !(res[1]);
            res[5] = (c > d) ^ (c < a);

            return res;
        }
    }
}
