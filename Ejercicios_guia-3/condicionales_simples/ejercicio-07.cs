using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_simples
{
    class ejercicio_07
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Bienvenido");
            double amount, share;
            Console.WriteLine("digite el valor del monto de la fianza:");
            bool resp1 = double.TryParse(Console.ReadLine(), out amount);
            share = amount * 0.03;
            if (amount>50000)
            {
                share = amount * 0.02;
            }
            Console.WriteLine("su monto de fianza es: "+amount+" sus cuotas quedan en: "+share);
        }
    }
}
