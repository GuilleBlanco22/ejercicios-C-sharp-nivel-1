using System;

namespace lote1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] articuloV = new int [3];
            int [] cantidadV = new int [3];
            int [] precioV = new int [3];
            int articulo = 0, cantidad = 0;
            int precio = 0;

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Ingrese Nro de articulo");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Cantidad");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio");
                precio = int.Parse(Console.ReadLine());

                articuloV[x] = articulo;
                cantidadV[x] = cantidad;
                precioV[x] = precio;
            }
            int [] compraCliente = new int [3];
            int [] noVentas = new int [3];
            int cliente, cantUniVendidas;

            for (int x = 0; x < 3; x++)
            {
                compraCliente[x] = 0;
                noVentas[x] = 0;
            }

            Console.WriteLine("Ingrese Nro de cliente");
            cliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nro de articulo");
            articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de unidades vendidas");
            cantUniVendidas = int.Parse(Console.ReadLine());

            int indice, total;

            while (cliente != 0)
            {
                indice = buscar (articulo, articuloV);

                total = cantUniVendidas * precioV[indice];
                compraCliente[cliente - 1] = total;
                noVentas[indice] = 1;

                Console.WriteLine("El cliente " + cliente);
                Console.WriteLine("Compro el articulo " + articulo);
                Console.WriteLine("Cantidad vendida: " + cantUniVendidas);
                Console.WriteLine("El total es " + total);



                Console.WriteLine("Ingrese Nro de cliente");
                cliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Nro de articulo");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de unidades vendidas");
                cantUniVendidas = int.Parse(Console.ReadLine());
            }
            int clienteMax = 0, max = 0;
            for (int x = 0; x < 3; x++)
            {
                if (compraCliente[x] > max)
                {
                    max = compraCliente[x];
                    clienteMax = x + 1;
                }
            }
            Console.WriteLine("Cliente con mayor compra es " + clienteMax);

            for (int x = 0; x < 3; x++)
            {
                if (noVentas[x] == 0)
                {
                    Console.WriteLine("No se vendio el articulo " + articuloV[x]);
                }
                
            }
           







        }
static int buscar(int articulo, int[] articuloV)
{
    for (int x = 0; x < articuloV.Length; x++)
    {
        if (articuloV[x] == articulo)
            return x;
    }
    return -1; // Item not found
}


        /*static int buscar (int articulo, int[] articuloV){
            for (int x = 0; x < 10; x++)
            {
                if (articuloV[x] == articulo)
                   return x;
                
            }
        }*/
 }
   }
