using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Ejercicio_03
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 03");
            /*Determinar cuantos hombres y cuantas mujeres se encuentran en un grupo de n personas,
            suponiendo que los datos son extraídos alumno por alumno.*/
            double agregar, num_M = 0, num_F = 0, total = 0;
            Console.WriteLine("desea agregar a alguien en el conteo: \n 1 - si\n 2 - no");
            _ = double.TryParse(Console.ReadLine(), out agregar);
            while (agregar == 1)
            {
                Console.WriteLine("el estudiante es mujer o hombre: \n 1 - mujer\n 2 - hombre");
                _ = double.TryParse(Console.ReadLine(), out double sexo);
                if (sexo==1)
                {
                    num_F += 1;
                }
                else
                {
                    num_M += 1;
                }
                if (sexo>0 || sexo < 3)
                {
                    total += 1;
                }
                Console.WriteLine("desea agregar a alguien en el conteo: \n 1 - si\n 2 - no");
                _ = double.TryParse(Console.ReadLine(), out agregar);
            }
            Console.WriteLine("el conteo total es de: " + total + "\n" + "el conteo total de mujeres es de: " + num_F + "\n" + "el conteo total de hombres es de: " + num_M);
        }
    }
}
