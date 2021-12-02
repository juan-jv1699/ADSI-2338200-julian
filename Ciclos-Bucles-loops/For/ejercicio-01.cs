using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class ejercicio_01
    {
        static void Maint(string[] args)
        {
            /*Calcular el promedio de un alumno que tiene 7 calificaciones en la materia de Diseño Estructurado
            de Algoritmos.*/
            Console.WriteLine("--------------------");
            double suma, promedio;
            suma = 0;
            Console.WriteLine("Digite las notas: ");
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("nota: " + i);
                _ = int.TryParse(Console.ReadLine(), out int nota);
                suma += nota;
            }
            promedio = suma / 7;
            Console.WriteLine("la suma es de: " + suma);
            Console.WriteLine("el promedio de nota es: "+ promedio);
        }
    }
}
