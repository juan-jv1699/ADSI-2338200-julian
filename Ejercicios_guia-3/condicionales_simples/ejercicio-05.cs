using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_simples
{
    class Class1
    {
        static void Maint(string[] args)
        {
            double tire_price, amount, total;
            Console.WriteLine("digite la cantidad de llantas que desea comprar: ");
            bool resp1 = double.TryParse(Console.ReadLine(), out amount);
            tire_price = 80000;
            if (amount>=5)
            {
                tire_price = 70000;
            }
            total = tire_price * amount;
            Console.WriteLine("la cantiad que desea comprar es: "+amount+" y el precio total es: "+total);
        }
    }
}
