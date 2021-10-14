using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_multiples
{
    class ejercicio_04
    {
        static void Maint(string[] args)
        {
            double var_x, var, total;
            Console.WriteLine("digite un numero");
            var_x = double.Parse(Console.ReadLine());
            var = var_x % 4;
            switch (var)
            {
                case 0:
                    total = Math.Pow(var_x, 2);
                    break;
                case 1:
                    total = var_x / 6;
                    break;
                case 2:
                    total = Math.Sqrt(var_x);
                    break;
                case 3:
                    total = (Math.Pow(var_x, 3) + 5);
                    break;
                default:
                    total = 0;
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine("total: " + total + Environment.NewLine + var);
        }
    }
}
