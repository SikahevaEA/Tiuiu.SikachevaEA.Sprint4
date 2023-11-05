using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tiuiu.SikachevaEA.Sprint4.V11.Lib
{
    public class DataService : ISprint4Task0V11
    {
        public int GetMultOddArrEl(int[] array)
        {
            int mult = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    mult *= array[i];
                }
            }
            return mult;
        }
    }
}