// See https://aka.ms/new-console-template for more information

            int [] articuloV = new int [10];
            int [] cantidadV = new int [10];
            float [] precioV = new float [10];
            int articulo, cantidad = 0;
            float precio;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese Nro de articulo");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Cantidad");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio");
                precio = float.Parse(Console.ReadLine());

                articuloV[x] = articulo;
                cantidadV[x] = cantidad;
                precioV[x] = precio;
            }
            float [] compraCliente = new float [10];
            int [] noVentas = new int [10];
            int cliente, cantUniVendidas;

            for (int x = 0; x < 10; x++)
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
                indice = buscar (articulo, ref articuloV [x]);

                total = cantidad * precioV[indice];
                compraCliente[cliente - 1] = total;
                noVentas[indice] = 1;

                Console.WriteLine("El cliente " + cliente);
                Console.WriteLine("Compro el articulo " + articulo);
                Console.WriteLine(cantUniVendidas + " cantidad");
                Console.WriteLine("El total es " + total);



                Console.WriteLine("Ingrese Nro de cliente");
                cliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Nro de articulo");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de unidades vendidas");
                cantUniVendidas = int.Parse(Console.ReadLine);
            }
            int clienteMax, max = 0;
            for (int x = 0; x < 10; x++)
            {
                if (compraCliente[x] > max)
                {
                    max = compraCliente[x];
                    clienteMax = x + 1;
                }
            }
            Console.WriteLine("Cliente con mayor compra es " + clienteMax);

            for (int x = 0; x < 10; x++)
            {
                if (noVentas[x] == 0)
                {
                    Console.WriteLine("No se vendio el articulo " + articuloV[x]);
                }
                
            }
           







        static int buscar (int articulo, ref int articuloV){
            for (int x = 0; x < 10; x++)
            {
                if (articulo == articuloV[x])
                {
                    return [x];
                }
            }
        }
        
