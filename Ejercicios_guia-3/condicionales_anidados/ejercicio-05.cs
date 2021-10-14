using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_anidados
{
    class ejercicio_05
    {
        static void Maint(string[] args)
        {
            double fruit_price, cantd_kilo, discount, total, total_pay;
            Console.WriteLine("cuantos kilos de manzana comprara: ");
            bool resp0 = double.TryParse(Console.ReadLine(),out cantd_kilo);
            fruit_price = 1300;
            total = fruit_price * cantd_kilo;
            if (cantd_kilo<=2)
            {
                discount = 0;
            }
            else if (cantd_kilo <= 5)
            {
                discount = total * 0.1;
            }
            else if (cantd_kilo<=10)
            {
                discount = total*0.15;
            }
            else
            {
                discount = total * 0.2;
            }
            total_pay = total - discount;
            Console.WriteLine("usted comprara: " + cantd_kilo + " kilos de manzana");
            Console.WriteLine("el valor por kilo es: " + fruit_price);
            Console.WriteLine("el total es: "+total);
            Console.WriteLine("su descuento es de: "+discount);
            Console.WriteLine("el total a pagar es: "+total_pay);
        }
    }
}
