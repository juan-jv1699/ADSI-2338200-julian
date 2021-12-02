using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_Bucles_loops
{
    class DoWhile1
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio practico");
            double contraseña=1243, validacion=0,intento=0;
            do
            {
                Console.WriteLine("digite la contraseña de cuatro digitos");
                _ = double.TryParse(Console.ReadLine(), out validacion);
                
                if (validacion == contraseña)
                {
                    Console.WriteLine("contraseña correcta bienvenido");
                }
                else
                {
                    Console.WriteLine("contraseña incorrecta");
                    intento ++;
                    if (intento > 3)
                    {
                        Console.WriteLine("ha ingresado la contraseña mal mas de 3 veces\nsu contraseña sera bloqueada");
                        validacion = contraseña;
                    }
                }
            }
            while (validacion != contraseña);
        }
    }
}
