using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_multiples
{
    class ejercicio_02
    {
        static void Maint(string[] args)
        {
            string name;
            double hectareas, tipo_fumigacion, tipo_1, tipo_2, tipo_3, tipo_4, total; 
            Console.WriteLine("ingrese el nombre del usuario:");
            name = Console.ReadLine();
            Console.WriteLine("cuantas hectareas desea fumigar:");
            _ = double.TryParse(Console.ReadLine(), out hectareas);
            Console.WriteLine("que tipo de fumigacion desea: " + Environment.NewLine + "1= tipo 1 fumigacion contra malas hierbas" + Environment.NewLine + "2= fumigacion contra moscas y mosquitos " + Environment.NewLine + "3= tipo 3 fumigacion contra gusanos" + Environment.NewLine + "4= tipo 4 fumigacion contra todo");
            _ = double.TryParse(Console.ReadLine(), out tipo_fumigacion);
            //while (tipo_fumigacion!=1 && tipo_fumigacion != 2 && tipo_fumigacion != 3 && tipo_fumigacion != 4)
            /*while (tipo_fumigacion>0 && tipo_fumigacion<5) //10 < 1 = F -- 10 > 4 = V -- F && V = F
            {
                Console.WriteLine("numero equivocado vuelvalo a intentar: " + Environment.NewLine + "1= tipo 1 fumigacion contra malas hierbas" + Environment.NewLine + "2= fumigacion contra moscas y mosquitos " + Environment.NewLine + "3= tipo 3 fumigacion contra gusanos" + Environment.NewLine + "4= tipo 4 fumigacion contra todo");
                _ = double.TryParse(Console.ReadLine(), out tipo_fumigacion);
            }*/
            while (tipo_fumigacion < 1 || tipo_fumigacion > 4) //10 < 1 = F -- 10 > 4 = V -- F || V = V
            {
                Console.WriteLine("numero equivocado vuelvalo a intentar: " + Environment.NewLine + "1= tipo 1 fumigacion contra malas hierbas" + Environment.NewLine + "2= fumigacion contra moscas y mosquitos " + Environment.NewLine + "3= tipo 3 fumigacion contra gusanos" + Environment.NewLine + "4= tipo 4 fumigacion contra todo");
                _ = double.TryParse(Console.ReadLine(), out tipo_fumigacion);
            }
            tipo_1 = 50000;
            tipo_2 = 70000;
            tipo_3 = 80000;
            tipo_4 = 190000;
            switch (tipo_fumigacion)
            {
                case 1:
                    tipo_fumigacion = tipo_1;
                    break;
                case 2:
                    tipo_fumigacion = tipo_2;
                    break;
                case 3:
                    tipo_fumigacion = tipo_3;
                    break;
                default:
                    tipo_fumigacion = tipo_4;
                    break;
            }
            total = hectareas * tipo_fumigacion;
            if (hectareas >= 100)
            {
                double discount = total * 0.05;
                total = total - discount;
            }
            if (total >= 1000000)
            {
                double discount2 = (total-1000000)*0.1;
                total = total - discount2;
            }
            Console.WriteLine("nombre: "+name+Environment.NewLine+"total a pagar: "+total+Environment.NewLine+"El valor de la fumigacion seleccionada es: "+tipo_fumigacion+" por hectarea");
        }
    }
}
