using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_multiples
{
    class ejercicio_03
    {
        static void Maint(string[] args)
        {
            byte number_shirt, shirt_price;
            double total, discount;
            Console.WriteLine("Cuantas camisas desea comprar");
            bool resp1 = byte.TryParse(Console.ReadLine(), out number_shirt);
            shirt_price = 2;
            total = shirt_price * number_shirt;
            if (number_shirt<3)
            {
                discount = total * 0.1;
                total = total - discount;
            }
            else
            {
                discount = total * 0.2;
                total = total - discount;
            }
            Console.WriteLine("la cantidad de camisas es: "+number_shirt+" el valor unitario es: "+shirt_price);
            Console.WriteLine("el total a pagar es: "+total);
            Console.WriteLine("su descuento es de "+discount);
        }
    }
}
