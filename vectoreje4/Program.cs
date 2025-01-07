using System;

namespace vectoreje4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
- Número de Artículo (1 a 15)
- Cantidad Vendida 

Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
Se pide determinar e informar:
a) El número de artículo que más se vendió en total.
b) Los números de artículos que no registraron ventas.
c) Cuantas unidades se vendieron del número de artículo 10.*/

         int numArticulo, cantidadVendida;
         int[] totalVentas = new int[15];

         for (int x = 0; x < 15; x++)
         {
            totalVentas[x] = 0;
         } 

         Console.WriteLine("Ingrese numero de articulo");
         numArticulo = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese cantidad vendida");
         cantidadVendida = int.Parse(Console.ReadLine());

         while (numArticulo != 0)
         {
            totalVentas[numArticulo - 1] += cantidadVendida;

            Console.WriteLine("Ingrese numero de articulo");
         numArticulo = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese cantidad vendida");
         cantidadVendida = int.Parse(Console.ReadLine());
         }
         int maxCantidad = totalVentas[0];
         int numMaximo = 1;
         for (int x = 0; x < 15; x++)
         {
            if (totalVentas[x] > maxCantidad)
            {
             maxCantidad = totalVentas[x];
             numArticulo = x + 1;
            }
         }
         Console.WriteLine("Producto mas vendido es " + numArticulo + " y la cantidad es " + maxCantidad);

         for (int x = 0; x < 15; x++)
         {
            if (totalVentas[x] == 0)
            {
                Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas.");
            }
         }
         Console.WriteLine("La cantidad vendida del producto 10 es: " + totalVentas[9]);

        }
    }
}
