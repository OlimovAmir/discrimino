using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrimino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение  а:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  c:");
            int c = Convert.ToInt32(Console.ReadLine());

            int d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("Корней нет");
                Console.WriteLine($"Дискриминант : {d}");
            }
            else if (d == 0) 
            {
                Console.WriteLine("Уровнение имеет всего один корень");
                double result1 = Math.Sqrt(d);
                int resultInt1 = (int)Math.Round(result1);
                int x1_1 = ((-b) + resultInt1) / 2 * a;
                Console.WriteLine($"X1 =   {x1_1}");
                Console.ReadKey();
            }
            else if (d > 0)
            {
                Console.WriteLine("Уровнение имеет два корня");
                double result = Math.Sqrt(d);
                int resultInt = (int)Math.Round(result);

                int x1 = ((-b) + resultInt) / 2 * a;
                int x2 = ((-b) - resultInt) / 2 * a;
                Console.WriteLine($"X1 =   {x1}");
                Console.WriteLine($"X2 =   {x2}");
                Console.ReadKey();
            }

            
            

        }
    }
}
