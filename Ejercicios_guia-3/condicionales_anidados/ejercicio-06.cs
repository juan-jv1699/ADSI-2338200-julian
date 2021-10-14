using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_anidados
{
    class ejercicio_06
    {
        static void Maint(string[] args)
        {
            double capital, prestamo, computo, mobiliario, incentivo_personal, insumos, incentivo, total;
            Console.WriteLine("digite su saldo: ");
            bool resp0 = double.TryParse(Console.ReadLine(), out capital);
            computo = 500000;
            mobiliario = 200000;
            if (capital<0)
            {
                prestamo = 1000000-capital;
                total = prestamo + capital;
            }
            else if (capital<2000000)
            {
                prestamo = 2000000 - capital;
                total = prestamo + capital;
            }
            else
            {
                total = capital;
                prestamo = 0;
            }
            incentivo = total - computo - mobiliario;
            incentivo_personal = incentivo / 2;
            insumos = incentivo / 2;
            Console.WriteLine("su saldo inicial es: $" + capital);
            Console.WriteLine("su prestamo sera de: $" + prestamo);
            Console.WriteLine("su nuevo saldo es: $" + total);
            Console.WriteLine("se destinara para equipo de computo: $" + computo + " y para mobiliario: $" + mobiliario);
            Console.WriteLine("se destinara: $" + incentivo_personal + " para incentivos al personal");
            Console.WriteLine("se destinara: $" + insumos + " para insumos");

        }
    }
}
