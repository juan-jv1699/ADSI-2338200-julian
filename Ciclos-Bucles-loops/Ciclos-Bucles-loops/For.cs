using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_Bucles_loops
{
    class For
    {
        static void Maint(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            for (int i=1; i<=10; i++)
            {
                //codigo que se requiere repetir
                Console.WriteLine("i : " + i);
            }
            Console.WriteLine("-----------------------------------------");
            for (int i=0; i<=100; i+=2)
            {

            }*/

            //solicitar el salario de n empleados y decir cuanto tienen que pagar cada uno por salud y pension
            //sabiendo que para salud el empleado debe cubrir el 4% y 6% para pension
            double num_empleados, total_pension, total_salud;
            Console.WriteLine("digite la cantidad de empleados: ");
            _= double.TryParse(Console.ReadLine(), out num_empleados);
            for (int i = 1; i <= num_empleados; i++)
            {
                Console.WriteLine("digite el salario del empleado " + i);
                _: double.TryParse(Console.ReadLine(), out double empleado);
                total_salud = empleado * 0.04;
                total_pension = empleado * 0.06;
                Console.WriteLine("este empleado debe pagar:\n"+ "por salud: " + total_salud +Environment.NewLine+ "por pension: "+ total_pension);
            }
        }
    }
}

