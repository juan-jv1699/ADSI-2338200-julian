using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class ejercicio_06
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("ejercicio 06");
            /*Calcular el promedio de edades de hombres, mujeres y de todo un grupo de n alumnos.*/
            int i=1,cantd, cantdh=0, cantdm=0, cantdp;
            int edad, edadh=0, edadm=0, promedioh=0,promediom=0;
            Console.WriteLine("cuantos estudiantes son:");
            _ = int.TryParse(Console.ReadLine(), out cantd);
            while (i <= cantd)
            {
                Console.WriteLine("el estudiante es hombre o mujer\n1) hombre\n2) mujer");
                _ = int.TryParse(Console.ReadLine(),out cantdp);
                Console.WriteLine("cual es la edad: \n");
                _ = int.TryParse(Console.ReadLine(), out edad);
               if (cantdp == 1)
                {
                    cantdh++;
                    edadh = edadh + edad;
                }
               else
                {
                    cantdm++;
                    edadm = edadm + edad;
                }
                i++;

            }
            promedioh = edadh / cantdh;
            promediom = edadm / cantdm;
            Console.WriteLine("la cantidad total de hombres es: " + cantdh);
            Console.WriteLine("la cantidad total de mujeres es: " + cantdm);
            Console.WriteLine("el promedio de edad de hombres es: " + promedioh);
            Console.WriteLine("el promedio de edad de mujeres es: " + promediom);
            
        }
    }
}
