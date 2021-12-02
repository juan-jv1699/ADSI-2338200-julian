using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class ejercicio_07
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 07");
            /*Al cerrar un expendio de naranjas, 15 clientes recibirán un 15% de descuento si compran más de 10
            kilos. Determinar cuánto pagará cada cliente y cuanto percibirá la tienda por esas compras.*/
            double ganancias=0,precio, descuento=0, kilos, precio_total;
            precio = 1000;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("¿cuantos kilos de naranja compro?: ");
                _ = double.TryParse(Console.ReadLine(), out kilos);
                precio_total = precio * kilos;
                if (kilos >= 15)
                {
                    descuento = precio_total * 0.15;
                    precio_total = precio_total - descuento;
                }
                ganancias= ganancias+precio_total;
            }
            Console.WriteLine("las ganancia de la empresa son: " + ((int)ganancias));
        }
    }
}
