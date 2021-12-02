using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class ejercicio_03
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 03");
            //Leer 20 números e imprimir cuantos son positivos, cuantos negativos y cuantos cero.
            double num, total_pos=0, total_neg=0, cero=0;
            Console.WriteLine("por favor digite 20 numeros reales:");
            for (int i = 1; i <= 20; i++)
            {
                _ = double.TryParse(Console.ReadLine(), out num);
                if (num == 0)
                {
                    cero = cero + 1;
                }
                else if (num<0)
                {
                    total_neg = total_neg + 1;
                }
                else
                {
                    total_pos = total_pos + 1;
                }
            }
            Console.WriteLine("el total de numeros positivos es: " + total_pos);
            Console.WriteLine("el total de numeros negativos es: " + total_neg);
            Console.WriteLine("el total de ceros es: " + cero);
        }
    }
}
