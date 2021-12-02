using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Ejercicio_02
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 02");
            /*Un alumno de la clase de lógica matemática desea desarrollar un algoritmo y diagrama de flujo en el
            cual introduzca un número entero positivo e invierta los dígitos del número. Mostrar el número
            invertido.*/
            int numero, residuo, num_invertido = 0, opcion=0;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            do
            {
                residuo = numero % 10;
                numero = numero / 10;
                num_invertido = num_invertido * 10 + residuo;
                Console.WriteLine("El numero inverso es: " + num_invertido);
                Console.WriteLine("desea continuar con otro numero:\n 1- si\n 2- no");
                opcion = int.Parse(Console.ReadLine());

            } while (opcion != 2);

            
        }
    }
}
