using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionales_multiples
{
    class ejercicio_05
    {
        static void Maint(string[] args)
        {
            double number_brushes, number_rollers, discount_brushes, discount_rollers, price_brushes, price_rollers, total_brushes, total_rollers, payment, total_buy;
            price_brushes = 2;
            price_rollers = 5;
            Console.WriteLine("digite la cantidad de rodillos: ");
            _= double.TryParse(Console.ReadLine(), out number_rollers);
            Console.WriteLine("digite la cantidad de brochas de cerdas: ");
            _= double.TryParse(Console.ReadLine(), out number_brushes);
            discount_brushes = price_brushes * 0.2;
            discount_rollers = price_rollers * 0.15;
            price_brushes = price_brushes - discount_brushes;
            price_rollers = price_rollers - discount_rollers;
            total_brushes = price_brushes * number_brushes;
            total_rollers = price_rollers * number_rollers;
            total_buy = total_brushes + total_rollers;
            Console.WriteLine("como desea pagar: " +"1//contado "+" 2//credito");
            _= double.TryParse(Console.ReadLine(), out payment);
            while (payment != 1 && payment != 2)
            {
                    Console.WriteLine("numero incorrecto");
                    Console.WriteLine("como desea pagar: " + "1//contado " + " 2//credito");
                    bool resp4 = double.TryParse(Console.ReadLine(), out payment);
            }
            if (payment==1)
            {
                double discount_total = total_buy * 0.07;
                total_buy = total_buy - discount_total;
                Console.WriteLine("su compra se pagara de contado");
            }
            else
            {
                Console.WriteLine("su compra se pagara a credito");
            }
            Console.WriteLine("su compra es: " + number_brushes + " brochas "+number_rollers+" rodillos");
            Console.WriteLine("el valor unitario de las borchas es: " + price_brushes + " y el valor unitario de los rodillos es: " + price_rollers);
            Console.WriteLine("el valor de la compra es: "+total_buy);
        }
    }
}
