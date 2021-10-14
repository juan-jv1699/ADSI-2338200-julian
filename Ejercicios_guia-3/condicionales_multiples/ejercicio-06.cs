using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_multiples
{
    class ejercicio_06
    {
        static void Maint(string[] args)
        {
            string tipo_año;
            double año, mes, dias=0;
            Console.WriteLine("digite el año:");
            _ = double.TryParse(Console.ReadLine(),out año);
            Console.WriteLine("digite el mes:" + Environment.NewLine + "1-enero" + Environment.NewLine + "2-febrero" + Environment.NewLine + "3-marzo" + Environment.NewLine + "4-abril" + Environment.NewLine +"5-mayo"+ Environment.NewLine+"6-junio"+ Environment.NewLine+"7-julio"+ Environment.NewLine+"8-agosto"+ Environment.NewLine+"9-septiembre"+ Environment.NewLine+"10-octubre"+ Environment.NewLine+"11-noviembre"+ Environment.NewLine+"12-diciembre");
            _ = double.TryParse(Console.ReadLine(), out mes);
            while (mes !=1 && mes !=2 && mes !=3 && mes !=4 && mes !=5 && mes !=6 && mes !=7 && mes !=8 && mes !=9 && mes !=10 && mes !=11 && mes != 12)
            {
                Console.WriteLine("el mes es incorrecto vuelva a intentarlo:" + Environment.NewLine + "1-enero" + Environment.NewLine + "2-febrero" + Environment.NewLine + "3-marzo" + Environment.NewLine + "4-abril" + Environment.NewLine + "5-mayo" + Environment.NewLine + "6-junio" + Environment.NewLine + "7-julio" + Environment.NewLine + "8-agosto" + Environment.NewLine + "9-septiembre" + Environment.NewLine + "10-octubre" + Environment.NewLine + "11-noviembre" + Environment.NewLine + "12-diciembre");
                _ = double.TryParse(Console.ReadLine(), out mes);
            }
            if (año % 4==0 && ((año % 100 !=0)||(año % 400 == 0)))
            {
                tipo_año = "bisiesto";
            }
            else
            {
                tipo_año = "no bisiesto";
            }
            switch (mes)
            {
                case 1:
                    dias = 31;
                    break;
                case 2:
                    dias = 28;
                    break;
                case 3:
                    dias = 31;
                    break;
                case 4:
                    dias = 30;
                    break;
                case 5:
                    dias = 31;
                    break;
                case 6:
                    dias = 30;
                    break;
                case 7:
                    dias = 31;
                    break;
                case 8:
                    dias = 31;
                    break;
                case 9:
                    dias = 30;
                    break;
                case 10:
                    dias = 31;
                    break;
                case 11:
                    dias = 30;
                    break;
                case 12:
                    dias = 31;
                    break;
            }
            if (tipo_año== "bisiesto" && mes==2)
            {
                dias = 29;
            }
            Console.WriteLine("el año es: " + año + Environment.NewLine + "este año es " + tipo_año + Environment.NewLine+"el mes es: "+mes + " y tiene "+dias+" dias");
            
        }
    }
}
