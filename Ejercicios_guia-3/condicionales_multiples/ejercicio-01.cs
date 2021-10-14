using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_multiples
{
    class ejercicio_01
    {
        static void Maint(string[] args)
        {
            byte num_1, num_2;
            Console.WriteLine("digite el numero 1");
            bool resp1 = byte.TryParse(Console.ReadLine(), out num_1);
            Console.WriteLine("digite el numero 2");
            bool resp2 = byte.TryParse(Console.ReadLine(), out num_2);
            if (num_1 > num_2)
            {
                Console.WriteLine("el orden es: " + num_1 + num_2);

            }
            else
            {
                Console.WriteLine("el orden es: "+num_2+"-"+num_1);
            }
        }
    }
}
