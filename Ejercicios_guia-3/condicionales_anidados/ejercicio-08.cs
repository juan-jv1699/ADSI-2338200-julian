using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_anidados
{
    class ejercicio_08
    {
        static void Maint(string[] args)
        {
            int hours_worked, hour_pay, hour_ext_pay, hours_extraW, pay, pay_extras, total;
            string name;
            Console.WriteLine("digite su nombre:");
            name = Console.ReadLine();
            Console.WriteLine("digite la cantidad de horas trabajadas:");
            bool resp0 = int.TryParse(Console.ReadLine(), out hours_worked);
            hour_pay = 6250;
            hour_ext_pay = hour_pay* 2;
            hours_extraW = hours_worked - 40;
            pay = hours_worked * hour_pay;
            pay_extras = hours_extraW * hour_ext_pay;
            if (hours_worked > 40)
            {
                pay = hours_worked * hour_pay-hours_extraW*hour_pay;
                total = pay + pay_extras;
            }
            else if (hours_worked > 50)
            {
                pay = hours_worked * hour_pay - hours_extraW * hour_pay;
                hour_ext_pay = 6250 * 3;
                hours_extraW = hours_worked - 50;
                pay_extras = hours_extraW * hour_ext_pay;
                total = pay + pay_extras + (125000);
            }
            else
            {
                total = pay;
            }
            Console.WriteLine("su nombre es: " + name);
            Console.WriteLine("usted trabajo " + hours_worked + " horas");
            Console.WriteLine("su sueldo es: $" + total);
            Console.WriteLine("usted trabajo: "+hours_extraW+" horas extras");
        }
    }
}
