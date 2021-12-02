using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class ejercicio_08
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 08");
			/*Encontrar el mayor valor de un conjunto de n números dados.*/
			int i = 1, num;
			double numero_datos=0, numero_mayor = 0;
			Console.WriteLine("cuantos numeros desea ingresar :");
			_ = int.TryParse(Console.ReadLine(), out num);

			while (i <= num)
			{

				Console.WriteLine("Ingrese los valores :" + i);
				_= double.TryParse(Console.ReadLine(), out numero_datos);

				if (numero_datos > numero_mayor)
				{
					numero_mayor = numero_datos;
				}
				i++;
			}
			Console.WriteLine("El mayor valor es :" + numero_mayor);
		}
    }
}
