using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_anidados
{
    class ejercicio_03
    {
        static void Maint(string[] args)
        {
            double price_computer, discount, amount_pc, total, total_pay;
            price_computer = 1100000;
            Console.WriteLine("digite la cantidad de computadores que desea comprar:");
            bool resp1 = double.TryParse(Console.ReadLine(), out amount_pc);
            total = amount_pc * price_computer;
            if (amount_pc<5)
            {
                discount = total * 0.1;
            }
            else if (amount_pc<10)
            {
                discount = total * 0.2;
            }
            else
            {
                discount = total * 0.4;
            }
            total_pay = total - discount;
            Console.WriteLine("usted comprara: "+amount_pc+" computadores");
            Console.WriteLine("el valor es de: " + total);
            Console.WriteLine("su descuento es de: " + discount);
            Console.WriteLine("el total a pagar es: " + total_pay);
        }
    }
}
