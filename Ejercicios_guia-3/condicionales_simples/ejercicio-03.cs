using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_simples
{
    class ejercicio_03
    {
        static void Maint(string[] args)
        {
            string costume;
            double price, discount, amount, total;
            Console.WriteLine("nombre del traje:");
            costume = Console.ReadLine();
            Console.WriteLine("que cantidad desea comprar:");
            bool resp = double.TryParse(Console.ReadLine(),out amount);
            Console.WriteLine("digite el precio unitario del traje:");
            bool resp2 = double.TryParse(Console.ReadLine(), out price);
            total = price * amount;
            if (amount>=3)
            {
                discount = total * 0.17;
                total = total - discount;
            }
            Console.WriteLine("usted desea comprar: " + costume);
            Console.WriteLine("la cantidad es: " + amount);
            Console.WriteLine("el valor unitario es: " + price);
            Console.WriteLine("su total a pagar es: " + total);

        }
    }
}
