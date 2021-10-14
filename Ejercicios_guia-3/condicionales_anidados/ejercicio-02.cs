using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_anidados
{
    class ejercicio_02
    {
        static void Maint(string[] args)
        {
            double amount, discount, total;
            Console.WriteLine("porfavor ingrese el valor de la compra");
            bool resp1 = double.TryParse(Console.ReadLine(), out amount);
            if (amount>10000)
            {
                discount = amount * 0.1;
            }
            else if (amount>20000)
            {
                discount = amount * 0.2;
            }
            else
            {
                discount = 0;
            }
            total = amount - discount;
            Console.WriteLine("el monto de su compra es de: "+amount+" y su valor a pagar es de: "+total);
        }
    }
}
