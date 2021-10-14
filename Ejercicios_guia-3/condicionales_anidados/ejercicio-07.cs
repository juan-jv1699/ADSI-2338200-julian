using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_anidados
{
    class ejercicio_07
    {
        static void Maint(string[] args)
        {
            int num1, num2, total;
            Console.WriteLine("digite el numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el numero 2");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                total = num1 * num2;
            }
            else if (num1 > num2)
            {
                total = num1 - num2;
            }
            else
            {
                total = num1 + num2;
            }
            Console.WriteLine("el primer numero digita es: " + num1 + " y el segundo es: " + num2);
            Console.WriteLine("el resultado es: " + total);
        }
    }
}
