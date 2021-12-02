using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class ejercicio_03
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 03");
            /*En la Cámara de Diputados se levanta una encuesta con todos los integrantes con el fin de determinar
            que porcentaje de los n diputados esta a favor del Tratado de Libre Comercio, que porcentaje esta en
            contra y que porcentaje se abstiene de opinar.
            El programa debe preguntar si se desea continuar ingresando datos.*/
            int cantd=0, aFavor=0, contra=0, noVota=0,respuesta;
            double porcentajeFavor=0, porcentajeContra=0, porcentajeNovota=0;
            do
            {
                do
                {
                    Console.WriteLine("Cual es su voto: \n 1- a favor\n 2- en contra\n 3- se abstiene de votar\n");
                    _ = int.TryParse(Console.ReadLine(), out respuesta);
                    if (respuesta != 1 && respuesta != 2 && respuesta != 3)
                    {
                        Console.WriteLine("opcion incorrecta vuelva a intentarlo");
                    }
                } while (respuesta != 1 && respuesta != 2 && respuesta !=3);
                    
                if (respuesta == 1)
                {
                    aFavor++;
                }
                else if (respuesta == 2)
                {
                    contra++;
                }
                else
                {
                    noVota++;
                }
                cantd++;
                Console.WriteLine("desea continuar votando:\n 1- si\n 2- no\n");
                _ = int.TryParse(Console.ReadLine(), out respuesta);
            }
            while (respuesta!=2);
            porcentajeFavor=aFavor*100/cantd;
            porcentajeContra=contra*100/cantd;
            porcentajeNovota=noVota*100/cantd;
            Console.WriteLine("cantidad total de votantes: "+cantd);
            Console.WriteLine("cantidad total de votos a favor: "+aFavor);
            Console.WriteLine("cantidad total de votos en contra: "+contra);
            Console.WriteLine("cantidad total de personas que se abstienen de votar: "+noVota);
            Console.WriteLine("porcentaje de votos a favor: "+porcentajeFavor+ "%");
            Console.WriteLine("porcentaje de votos en contra: "+porcentajeContra+ "%");
            Console.WriteLine("porcentaje de votos nulos: "+porcentajeNovota+"%");
        }
    }
}
