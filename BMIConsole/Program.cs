using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BMICalcular bmiCalc = new BMICalcular();

            var height = 178m;
            var weight = 81m;

            string result = bmiCalc.Calc(SexType.Man,height, weight);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
