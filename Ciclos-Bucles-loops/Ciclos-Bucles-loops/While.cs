using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_Bucles_loops
{
    class While
    {
        static void Maint(string[] args)
        {
            /*int numero = 1;
            while (numero <= 10)
            {
                Console.WriteLine(numero);
            }*/
            //Desarrollar un algoritmo que lea n números positivos, determine y muestre el promedio de los n números positivos
            int contador = 1;
            int n;
            Console.WriteLine("cuantos numeros desea ingresar");
            _ = int.TryParse(Console.ReadLine(), out n);
            int suma=0, cantPositivos=0;
            double promedio;
            
            while (contador <= n) 
            {
                Console.WriteLine("digite un numero:");
                _ = int.TryParse(Console.ReadLine(), out int numero);
                if (numero > 0)
                {
                    suma += numero;
                    cantPositivos++;
                }
                contador++;
            }
            promedio = (double)suma / (double)cantPositivos;
        }
    }
}
