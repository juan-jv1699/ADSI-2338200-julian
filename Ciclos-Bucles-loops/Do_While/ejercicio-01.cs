using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class ejercicio_01
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Ejercicio 01");
            /*En un supermercado una ama de casa pone en su carrito los artículos que va tomando de los
            estantes. La señora quiere asegurarse de que el cajero le cobre bien lo que ella ha comprado, por lo
            que cada vez que toma un articulo anota su precio junto con la cantidad de artículos iguales que ha
            tomado y determina cuanto dinero gastara en ese articulo; a esto le suma lo que ira gastando en los
            demás artículos, hasta que decide que ya tomo todo lo que necesitaba. Ayúdale a esta señora a
            obtener el total de sus compras.*/
            double cantd=0, valorArt, precio, totalCompra=0, opcion;
            do
            {
                Console.WriteLine("Digite el valor del articulo");
                _ = double.TryParse(Console.ReadLine(), out valorArt);
                Console.WriteLine("Digite la cantidad");
                _ = double.TryParse(Console.ReadLine(), out cantd);
                precio = valorArt * cantd;
                Console.WriteLine("El subtotal de este articulo es: " + precio);
                totalCompra += precio;
                do
                {
                    Console.WriteLine("desea continuar comprando: \n 1- si\n 2- no");
                    _ = double.TryParse(Console.ReadLine(), out opcion);
                    if (opcion != 1 && opcion != 2)
                    {
                        Console.WriteLine("Opcion incorrecta vuelva a intentar");
                    }
                }
                while (opcion != 1 && opcion != 2);
                
            }
            while (opcion != 1);
        }
    }
}
