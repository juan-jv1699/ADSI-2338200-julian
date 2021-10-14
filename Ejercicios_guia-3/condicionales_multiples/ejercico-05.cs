using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_multiples
{
    class ejercico_05
    {
        static void Maint(string[] args)
        {
            double clave, precio_llamada, numero_minutos, total_llamada;
            Console.WriteLine("digite la clave correspondiente al destino que desea llamar: "+Environment.NewLine+"12- america del norte"+Environment.NewLine+"15- america central"+Environment.NewLine+"18- america del sur"+Environment.NewLine+"19- europa"+Environment.NewLine+"23- asia"+Environment.NewLine+"25- africa"+Environment.NewLine+"29- oceania");
            _ = double.TryParse(Console.ReadLine(), out clave);
            while (clave!=12 && clave!=15 && clave !=18 && clave !=19 && clave !=23 && clave !=25 && clave != 29)
            {
                Console.WriteLine("error digite nuevamente la clave: " + Environment.NewLine + "12- america del norte" + Environment.NewLine + "15- america central" + Environment.NewLine + "18- america del sur" + Environment.NewLine + "19- europa" + Environment.NewLine + "23- asia" + Environment.NewLine + "25- africa" + Environment.NewLine + "29- oceania");
                _ = double.TryParse(Console.ReadLine(), out clave);
            }
            Console.WriteLine("cuantos minutos duro la llamada: ");
            _ = double.TryParse(Console.ReadLine(), out numero_minutos);
            switch (clave)
            {
                case 12:
                    precio_llamada = 200;
                    break;
                case 15:
                    precio_llamada = 220;
                    break;
                case 18:
                    precio_llamada = 450;
                    break;
                case 19: precio_llamada = 350;
                    break;
                case 23: precio_llamada = 600;
                    break;
                case 25:
                    precio_llamada = 600;
                    break;
                default:
                    precio_llamada = 500;
                    break;
            }
            total_llamada = numero_minutos * precio_llamada;
            Console.WriteLine("el precio de la llamada es: " + total_llamada +Environment.NewLine+ "la cantidad de minutos fue: "+numero_minutos + Environment.NewLine+"el valor por minuto fue: " +precio_llamada);
        }
    }
}
