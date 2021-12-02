using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class ejercicio_09
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 09");
			/*Escribir un programa que muestre el siguiente menú y que permita pasar magnitudes de grados a
			radianes y de radianes a grados.
			1. Pasar de grados a radianes
			2. Pasar de radianes a grados
			3. Salir del programa*/
			int menu, radianes, grados;
			double PI = 3.1416, totalRadianes, totalGrados;
			bool validar;

			do
			{
				Console.WriteLine("Ingrese una Opcion:");
				Console.WriteLine("1. Pasar de grados a radianes");
				Console.WriteLine("2. Pasar de radianes a grados");
				Console.WriteLine("3. Salir del programa");
				validar = int.TryParse(Console.ReadLine(), out menu);

				if (menu == 1)
				{
					Console.WriteLine("Ingrese la cantidad de grados");
					validar = int.TryParse(Console.ReadLine(), out grados);

					totalRadianes = grados * PI / 180;
					Console.WriteLine("El total de radianes es: " + totalRadianes);
				}
				else if (menu == 2)
				{
					Console.WriteLine("Ingrese la cantidad de radianes");
					validar = int.TryParse(Console.ReadLine(), out radianes);

					totalGrados = (radianes * 180) / PI;
					Console.WriteLine("El total de grados es: " + totalGrados);
				}
				else if (menu == 3)
				{
					Console.WriteLine("Adios!");
				}

				Console.WriteLine("ingrese nuevamente una opcion");
				validar = int.TryParse(Console.ReadLine(), out menu);

			} while (menu != 3);
		}
    }
}
