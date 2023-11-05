using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint4.V12.Lib;

namespace Tiuiu.SikachevaEA.Sprint4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int len;
            Console.WriteLine("Введите колличество элементов масства");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
