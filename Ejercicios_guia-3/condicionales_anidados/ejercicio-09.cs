using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_anidados
{
    class ejercicio_09
    {
        static void Maint(string[] args)
        {
            int age, time_worked;
            Console.WriteLine("por favor digite su edad:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("por favor digite el tiempo trabajado");
            time_worked = int.Parse(Console.ReadLine());
            if (age >= 60 && time_worked < 25)
            {
                Console.WriteLine("jubilacion por edad");
            }
            else if (age < 60 && time_worked >= 25)
            {
                Console.WriteLine("jubilacion por antiguedad joven");
            }
            else
            {
                Console.WriteLine("jubilacion por antiguedad adulta");
            }
        }
    }
}
