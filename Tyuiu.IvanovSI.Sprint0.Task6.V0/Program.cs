using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.IvanovSI.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] narraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов Массива = " + DataService.AdditionArray(narraynums));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(narraynums));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(narraynums));
            Console.ReadKey();
        }
    }
}
