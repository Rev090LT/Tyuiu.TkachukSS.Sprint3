using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TkachukSS.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 0)
                {
                    res = ((Math.Cos(x) / x) + 3);
                    res *= res;
                }
                else
                {
                    break;
                }
            }
            return res;
        }
    }
}
