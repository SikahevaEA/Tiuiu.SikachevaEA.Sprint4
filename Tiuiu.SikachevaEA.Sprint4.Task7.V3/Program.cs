using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint4.Task7.V3.Lib;

namespace Tiuiu.SikachevaEA.Sprint4.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];

            string str = "27182818";

            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");           

            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Количество нечётных числе в матрице = " + res);
            Console.ReadKey();
        }
    }
}
