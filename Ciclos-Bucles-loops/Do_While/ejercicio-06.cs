using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class ejercicio_06
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("ejerciio 06");
			/*Leer por cada alumno de Diseño estructurado de algoritmos su número de control y su calificación en
            cada una de las 5 unidades de la materia. Al final que escriba el número de control del alumno que
              obtuvo mayor promedio. Suponga que los alumnos tienen diferentes promedios.*/
			int C = 1, control, opción;
			double calif, calif_T = 0, prom, prom_M = 0;
			do
			{
				Console.WriteLine("Digite el numero del control");
				control = int.Parse(Console.ReadLine());

				do
				{
					Console.WriteLine("Digite la calificacion " + C);
					bool resp = double.TryParse(Console.ReadLine(), out calif);

					calif_T += calif; //calif_T = calif_T + calif;
					C++;

				} while (C <= 5);

				prom = calif_T / 5;

				if (prom > prom_M)
				{
					prom_M = prom;
				}


				Console.WriteLine("Ingrese #1 si deseas ingresar mas datos o ingrese #2 si deseas finalizar");
				bool resp2 = int.TryParse(Console.ReadLine(), out opción);

			} while (opción != 2);

			Console.WriteLine("E total de promedio mayor es: " + prom_M);
			Console.WriteLine("Numero Control: " + control);
		}
    }
}
