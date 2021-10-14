using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_simples
{
    class ejercicio_01
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Bienvenido");
            string name;
            double pay_hour, hour_work, salary, discount, total;

            Console.WriteLine("¿Cual es su nombre?");
            name = Console.ReadLine();
            Console.WriteLine("digite el valor de la hora de trabajo");
            bool resp = double.TryParse(Console.ReadLine(), out pay_hour);
            Console.WriteLine("digite la cantidad de horas que trabajo");
            bool resp1 = double.TryParse(Console.ReadLine(), out hour_work);
            salary = hour_work * pay_hour;
            discount = salary * 0.05;
            if (hour_work > 40)
            {
                total = salary + discount;
                Console.WriteLine("su incentivo es de: " + discount);
                salary = total;
            }
            Console.WriteLine("su nombre es: " + name);
            Console.WriteLine("usted trabajo esta semana: " + hour_work + " horas");
            Console.WriteLine("su sueldo es: " + salary);
        }
    }
}
