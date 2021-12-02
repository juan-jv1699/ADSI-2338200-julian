using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class ejercicio_05
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 05");
            /*Calcular la suma siguiente:
            100 + 98 + 96 + 94 + . . . + 0 en este orden*/

            int suma = 0, i = 100;

            do
            {
                suma += i;
                i -= 2;
            } while (i >= 0);

            Console.WriteLine("la suma es: " + suma);
        }
    }
}
