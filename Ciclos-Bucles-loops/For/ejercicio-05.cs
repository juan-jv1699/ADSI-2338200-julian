using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class ejercicio_05
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 05");
            /*Calcular e imprimir la tabla de multiplicar de un número cualquiera. Imprimir el multiplicando, el
            multiplicador y el producto.*/
            double num=0, resultado;
            Console.WriteLine("digite el numero que desea multiplicar");
            _ = double.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("La tabla de multiplicar para este numero es :\n");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num * i;
                Console.WriteLine("el resultado de " + num + " x " + i + " es igual a: "+resultado+"\n");
                Console.WriteLine("el multiplicando es "+num+"\n"+"el multiplicador es "+i+ "\n"+"el producto es "+resultado+"\n");
            }
        }
    }
}
