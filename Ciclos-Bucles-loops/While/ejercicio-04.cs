using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class ejercicio_04
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("ejercicio 04");
            /*El Depto. de Seguridad Publica y Transito del D.F. desea saber, de los n autos que entran a la ciudad
            de México, cuantos entran con calcomanía de cada color. Conociendo el último dígito de la placa de
            cada automóvil se puede determinar el color de la calcomanía utilizando la sig. relación:
            DÍGITO COLOR
            1 o 2 amarilla
            3 o 4 rosada
            5 o 6 roja
            7 o 8 verde
            9 o 0 azul*/
            double comprobante,amarilla=0, rosada=0, roja=0, verde=0, azul=0, total=0,color;
            Console.WriteLine("ingresar vehiculo: \n 1 - si\n 2 - no");
            comprobante = double.Parse(Console.ReadLine());
            while (comprobante == 1)
            {
                total += 1;
                Console.WriteLine("de que color es la calcomania\n1 - amarilla\n2 - rosada\n3 - roja\n4 - verde\n5 - azul ");
                color = double.Parse(Console.ReadLine());
                if (color == 1)
                {
                    amarilla += 1;
                }
                else if (color ==2)
                {
                    rosada += 1;
                }
                else if (color == 3)
                {
                    roja += 1;
                }
                else if (color == 4)
                {
                    verde += 1;
                }
                else
                {
                    azul += 1;
                }
                Console.WriteLine("ingresar vehiculo: \n 1 - si\n 2 - no");
                comprobante = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("el total de vehiculos es: " + total);
            Console.WriteLine(" el numero de vehiculos con calcomania amarilla es de: " +amarilla);
            Console.WriteLine(" el numero de vehiculos con calcomania rosada es de: " +rosada);
            Console.WriteLine(" el numero de vehiculos con calcomania roja es de: " +roja);
            Console.WriteLine(" el numero de vehiculos con calcomania verde es de: " +verde);
            Console.WriteLine(" el numero de vehiculos con calcomania azul es de: " +azul);
        }
    }
}
