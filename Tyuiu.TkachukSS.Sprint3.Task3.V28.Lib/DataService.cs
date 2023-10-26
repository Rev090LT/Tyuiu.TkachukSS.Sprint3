using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TkachukSS.Sprint3.Task3.V28.Lib
{
    public class DataService
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    value = value.Replace(c, item);
                }
            }
            return value;
        }
    }
}