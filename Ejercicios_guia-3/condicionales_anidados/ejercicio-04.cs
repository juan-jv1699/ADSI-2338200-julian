using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_anidados
{
    class ejercicio_04
    {
        static void Maint(string[] args)
        {
            double unit_tire, total, amount_tire;
            Console.WriteLine("cuantas llantas desea comprar: ");
            bool resp0 = double.TryParse(Console.ReadLine(), out amount_tire);
            if (amount_tire<5)
            {
                unit_tire = 90000;
            }
            else if (amount_tire<=10)
            {
                unit_tire = 80000;
            }
            else
            {
                unit_tire = 70000;
            }
            total = unit_tire * amount_tire;
            Console.WriteLine("usted comprara " + amount_tire + " llantas ponchadas");
            Console.WriteLine("el valor de cada una es: " + unit_tire);
            Console.WriteLine("el total a pagar es: " + total);
        }
    }
}
