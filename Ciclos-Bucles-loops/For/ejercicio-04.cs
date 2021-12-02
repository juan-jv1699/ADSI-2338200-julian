using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class ejercicio_04
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 04");
            /*Suponga que se tiene un conjunto de calificaciones de un grupo de 40 alumnos. Realizar un algoritmo
            para calcular la calificación promedio y la calificación más baja de todo el grupo.*/
            double nota, nota_baja=5, total_notas=0,promedio;
            Console.WriteLine("digite las notas ");
            for (int i =1; i <=40; i++)
            {
                Console.WriteLine("nota ->" + i);
                _ = double.TryParse(Console.ReadLine(), out nota);
                total_notas += nota;
                if (nota < nota_baja)
                {
                    nota_baja = nota;
                }
            }
            Console.WriteLine(total_notas);
            promedio = total_notas / 40;
            Console.WriteLine("el promedio del grupo es: "+promedio+"\n"+"la nota mas baja fue: "+nota_baja);
        }
    }
}
