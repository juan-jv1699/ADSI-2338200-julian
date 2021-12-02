using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class ejercicio
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 07");
            /*Encontrar el menor valor de un conjunto de n números dados.*/
            int cantid, num, num2=2000000000,i=1;
            Console.WriteLine("digite la cantidad de numeros en el conjunto: ");
            _ = int.TryParse(Console.ReadLine(),out cantid);
            while (i <= cantid)
            {
                Console.WriteLine("digite el numero "+i);
                _ = int.TryParse(Console.ReadLine(),out num);
                if (num < num2)

                {
                    num2 = num;
                }
                i++;
            }
            Console.WriteLine("el numero menor es: \n"+num2);
        }
    }
}

