using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class ejercicio_08
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 08");
			/*Hacer un programa que lea caracteres desde teclado y vaya contando las vocales que aparecen. El
             programa terminará cuando lea el carácter # y entonces mostrará un mensaje indicando cuántas
              vocales ha leído (cuántas de cada una de ellas).*/
			String letra, cadena;
			int CantL = 0, i = 1;

			do
			{
				Console.WriteLine("Ingrese una letra");
				cadena = Console.ReadLine();
				letra = cadena.ToLower();

				if (letra == "a")
				{
					CantL++; // CantL = CantL + 1;

					Console.WriteLine("La letra ingresada fue: " + cadena);
					Console.WriteLine("la cantidad de letras de (A) hasta el momento es: " + CantL);
				}
				else
				{
					Console.WriteLine("La letra ingresada fue: " + cadena);
				}

				i++;
			} while (CantL <= 10);
		}
    }
}
