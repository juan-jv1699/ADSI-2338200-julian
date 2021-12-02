using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class ejercicio_02
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 02");
            /*En una empresa se requiere calcular el salario semanal de cada uno de los n obreros que laboran en
            ella. El salario se obtiene de la sig. forma:
            Si el obrero trabaja 40 horas o menos se le paga $20 por hora
            Si trabaja más de 40 horas se le paga $20 por cada una de las primeras 40 horas y $25 por cada hora
            extra.*/
            double empleado, salario, horas_trab, horas_extra,extra, total ;
            string nombre;
            Console.WriteLine("desea ingresar un usuario:\n 1 - Si \n 2 - No");
            empleado = double.Parse(Console.ReadLine());
            while (empleado == 1)
            {
                Console.WriteLine("indique el nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("cuantas horas trabajo esta semana: ");
                _ = double.TryParse(Console.ReadLine(), out horas_trab);
                salario = 20;
                total = salario * horas_trab;
                if (horas_trab > 40)
                {
                    horas_extra = horas_trab - 40;
                    extra = horas_extra * 25;
                    total = total - (horas_extra * salario);
                    total = total + extra;
                }
                Console.WriteLine("el empleado es: " + nombre);
                Console.WriteLine("el salario es: " + total);
                Console.WriteLine("desea ingresar un usuario:\n 1 - Si \n 2 - No");
                empleado = double.Parse(Console.ReadLine());
            }

        }
    }
}
