using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Ejercicio_01
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 01");
            /*Una compañía de seguros tiene contratados a n vendedores. Cada uno hace tres ventas a la semana.
            Su política de pagos es que un vendedor recibe un sueldo base, y un 10% extra por comisiones de
            sus ventas. El gerente de su compañía desea saber cuanto dinero obtendrá en la semana cada
            vendedor por concepto de comisiones por las tres ventas realizadas, y cuanto tomando en cuenta su
            sueldo base y sus comisiones.*/
            double num_empl,total_vent,sueldo_base, comision,total,meta;
            string nombre;
            Console.WriteLine("digite el numero de empleados: ");
            _ = double.TryParse(Console.ReadLine(), out num_empl);
            for (int i=0; i<=num_empl; i++)
            {
                Console.WriteLine("a continuacion digite el nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("ahora digite el sueldo base del empleado: ");
                sueldo_base = double.Parse(Console.ReadLine());
                Console.WriteLine("cumplio con la meta de ventas: (1)si\n(2)no");
                meta = double.Parse(Console.ReadLine());
                comision = 0;
                total = sueldo_base + comision;
                if (meta==2)
                {
                    Console.WriteLine("el empleado no comisiono --- \n su sueldo es: " + total);
                }
                while (meta==1)
                {
                    Console.WriteLine("cuanto es el valor total de las ventas de la semana: ");
                    total_vent = double.Parse(Console.ReadLine());
                    comision = total_vent * 0.1;
                    total = sueldo_base + comision;
                    Console.WriteLine("el sueldo es: " + total);
                    Console.WriteLine("el total de comision es: " + comision);
                }
                
            }

        }
    }
}

