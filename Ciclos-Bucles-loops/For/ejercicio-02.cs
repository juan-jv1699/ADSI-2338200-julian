using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class ejercicio_02
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 02");
            /*Leer 10 números e imprimir solamente los números positivos*/
            double num=0;
            List<double> Lista= new List<double>();
       


            Console.WriteLine("escriba los numeros que desee: ");
            for (int i = 1; i < 11; i++)
            {
                _ = double.TryParse(Console.ReadLine(), out num);
                if (num > 0)
                {
                    Console.WriteLine("este es un numero positivo");

                }
            }
        }
    }
}
