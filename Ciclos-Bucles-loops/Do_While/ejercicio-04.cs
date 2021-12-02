using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class ejercicio_04
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 04");
			/*Un censador recopila ciertos datos aplicando encuestas para el último Censo Nacional de Población
           y Vivienda. Desea obtener de todas las personas que alcance a encuestar en un día, que porcentaje
            tiene estudios de primaria, secundaria, carrera técnica, estudios profesionales y estudios de
               posgrado.
            El programa debe preguntar si se desea continuar ingresando datos.*/

			int seleccion, contPrimaria = 0, contSecu = 0, contTec = 0, contPro = 0, contPos = 0, repita, cantTotal = 0;
			double porcentaje1, porcentaje2, porcentaje3, porcentaje4, porcentaje5;
			bool validar;

			do
			{
				Console.WriteLine("Ingrese una opcion");
				Console.WriteLine("1.estudios de primaria");
				Console.WriteLine("2.estudios de secundaria");
				Console.WriteLine("3.estudios de carrera tecnica");
				Console.WriteLine("4.estudios profesionales");
				Console.WriteLine("5.estudios de posgrado");
				validar = int.TryParse(Console.ReadLine(), out seleccion);

				if (seleccion == 1)
				{
					contPrimaria++;
				}
				else if (seleccion == 2)
				{
					contSecu++;
				}
				else if (seleccion == 3)
				{
					contTec++;
				}
				else if (seleccion == 4)
				{
					contPro++;
				}
				else if (seleccion == 5)
				{
					contPos++;
				}
				else
				{
					Console.WriteLine("Error ingrese nuevamente una opcion");
					validar = int.TryParse(Console.ReadLine(), out seleccion);
				}
				cantTotal++;

				Console.WriteLine("Ingrese (1) si quiere ingresar mas datos, o ingrese (2) si quiere finalizar");
				validar = int.TryParse(Console.ReadLine(), out repita);

				if (repita != 1 && repita != 2)
				{
					Console.WriteLine("Error al ingresar, ingrese nuevamente una opcion");
					validar = int.TryParse(Console.ReadLine(), out repita);
				}
			} while (repita != 2);
			porcentaje1 = contPrimaria * 100 / cantTotal;
			porcentaje2 = contSecu * 100 / cantTotal;
			porcentaje3 = contTec * 100 / cantTotal;
			porcentaje4 = contPro * 100 / cantTotal;
			porcentaje5 = contPos * 100 / cantTotal;

			Console.WriteLine("El total de personas de primaria es: " + contPrimaria + " es un porcentaje total de: " + porcentaje1);
			Console.WriteLine("El total de personas de secundaria es: " + contSecu + " es un porcentaje total de: " + porcentaje2);
			Console.WriteLine("El total de personas de carrera tecnica es: " + contTec + " es un porcentaje total de: " + porcentaje3);
			Console.WriteLine("El total de personas de estudios profesionales es: " + contPro + " es un porcentaje total de: " + porcentaje4);
			Console.WriteLine("El total de personas de estudios de posgrado es: " + contPos + " es un porcentaje total de: " + porcentaje5);
		}
    }
}
