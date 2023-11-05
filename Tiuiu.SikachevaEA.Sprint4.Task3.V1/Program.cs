using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint4.Task3.V1.Lib;

namespace Tiuiu.SikachevaEA.Sprint4.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas2 = new int[5, 5] { { 3, 4, 3, 4, 1 },
                                          { 8, 1, 6, 6, 9 },
                                          { 9, 8, 5, 1, 3 },
                                          { 1, 8, 7, 1, 2 },
                                          { 9, 9, 7, 5, 6 } };
            
            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;


            DataService ds = new DataService();
           
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int res = ds.Calculate(mas2);

            Console.WriteLine("Сумма элементов последней строки массива = " + res);
            Console.ReadKey();
        }
    }
}
