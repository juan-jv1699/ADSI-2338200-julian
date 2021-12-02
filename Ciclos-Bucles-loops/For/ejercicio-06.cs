using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class ejercicio_06
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 06");
            /*Una persona debe realizar un muestreo con 50 personas para determinar el promedio de peso de los
            niños, jóvenes, adultos y adultos mayores que existen en su zona habitacional. Se determinan las
            categorías con base en la sig, tabla

            CATEGORIA EDAD
            Niños 0 – 12
            Jóvenes 13 - 29
            Adultos 30 - 59
            Adultos Mayores 60 en adelante*/
            int edad, promedio, cantidad_total=0, cant_niñ=0, cant_joven=0, cant_adultos=0, cant_mayores=0;
            Console.WriteLine("bienvenido al sistema");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("digite la edad del entrevistado");
                _ = int.TryParse(Console.ReadLine(), out edad);
                if (edad <= 12)
                {
                    cant_niñ += 1;
                }
                else if (edad <= 29)
                {
                    cant_joven += 1;
                }
                else if (edad <= 59)
                {
                    cant_adultos += 1;
                }
                else
                {
                    cant_mayores += 1;
                }
                cantidad_total += 1;
            }
            promedio = cantidad_total * 50;
            Console.WriteLine("La cantidad total de entrevistados es: "+cantidad_total);
            Console.WriteLine("la cantidad total de niños es "+cant_niñ+"\n"+"la cantidad total de jovenes es "+cant_joven+ "\n"+"la cantidad total de adultos es "+cant_adultos+ "\n"
                +"la cantida de adultos mayores es "+cant_mayores);
            Console.WriteLine("el promedio de edad es " + promedio);
        }
    }
}
