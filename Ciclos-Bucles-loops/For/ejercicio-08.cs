using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class ejercicio_08
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 08");
            /*Un alumno de la clase de lógica matemática desea desarrollar un programa que calcule el factorial
            de un número N, el cual le dará al usuario, el factorial de un número N, definido matemáticamente
            como N! se obtiene como la multiplicación de todos los números que están desde el 1 hasta el N = 1
            * 2 * 3 * ..... (N-2) * (N-1) * N, como se muestra en la figura, por definición el factorial de 0 es 1.*/
            int numero,factorial=1,num2;
            Console.WriteLine("digite el numero: ");
            _ = int.TryParse(Console.ReadLine(), out numero);
            for (int i=1;i<=numero;i ++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial del numero es: "+factorial);
        }
    }
}
