using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_Bucles_loops
{
    class DoWhile
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Hello World!");
            int opcion, num1=0, num2=0, resul=0;
            do
            {
                Console.WriteLine("seleccione la operacion que desea realizar");
                Console.WriteLine("1. suma\n2. resta\n3. multiplicacion\n4. division\n5. salir\n");
                _ = int.TryParse(Console.ReadLine(), out opcion);
                if (opcion>0 && opcion<6) 
                { 
                Console.WriteLine("digite el primer numero que desea usar:");
                _ = int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("digite el segundo numero que desea usar:");
                _ = int.TryParse(Console.ReadLine(), out num2);
                }
                switch (opcion)
                {
                    case 1:
                        resul = num1 + num2;
                        Console.WriteLine("usted decidio sumar:\nla suma de " + num1 +" y "+ num2 + " es igual a: " + resul);
                        break;
                    case 2:
                        resul = num1 - num2;
                        Console.WriteLine("usted decidio restar:\nla resta de " + num1 + " y " + num2 + " es igual a: " + resul);
                        break;
                    case 3:
                        resul = num1 * num2;
                        Console.WriteLine("usted decidio multiplicar:\nla multiplicacion de " + num1 + " y " + num2 + " es igual a: " + resul);
                        break;
                    case 4:
                        resul = num1 / num2;
                        Console.WriteLine("usted decidio dividir:\nla division de " + num1 + " y " + num2 + " es igual a: " + resul);
                        break;
                    case 5:
                        Console.WriteLine("usted decidio salir\n hasta la proxima");
                        break;
                    default:
                        Console.WriteLine("usted selecciono un numero de opcion incorrecta vuelva a intentarlo");
                        break;
                }
            }
            while (opcion!=5);
        }
    }
}
