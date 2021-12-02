using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class ejercicio_05
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("ejercicio 05");
            double cantd, nota=0;
            double i = 1, promedio, notagneral=0;
            Console.WriteLine("digite la cantidad de estudiantes: ");
            _ = double.TryParse(Console.ReadLine(), out cantd);
            while (i <= cantd)
            {
                Console.WriteLine("digite la nota del estudiante: " + i);
                _ = double.TryParse(Console.ReadLine(), out nota);
                notagneral = notagneral + nota;
                i++;
            }
            promedio = notagneral / cantd;
            Console.WriteLine("el promedio del grupo es: \n" + promedio);
        }
    }
}
