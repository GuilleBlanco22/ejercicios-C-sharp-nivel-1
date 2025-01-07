using System;

namespace ivanna
{
    class Program
    {
        static void Main(string[] args)
        {
            //maximo par, minimo primo, cantidad de impares.
            
            Console.WriteLine("Hola Ivanna :)");
            int n, bp, pri, maxPar = 0, minPrimo = 0;
            int bmaxPar = 0;
            int conI = 0;
            int bminPri = 0;
            

            Console.WriteLine("Ingrese un numero, ingrese 0 para terminar.");
            n = int.Parse(Console.ReadLine());
            
            while (n != 0){


              bp = par(n);

                if (bp == 1)
                {
                    if (bmaxPar == 0)
                    {
                        maxPar = n;
                        bmaxPar = 1;
                    }else if (n > maxPar)
                    {
                        maxPar = n;
                    }
                }else
                {
                    conI++;
                }





               pri = primo(n);
                if (pri == 1)
                {
                    if (bminPri == 0)
                    {
                        minPrimo = n;
                        bminPri = 1;
                    }else if (n < minPrimo)
                    {
                        minPrimo = n;
                    }
                }
                Console.WriteLine("Ingrese un numero, ingrese 0 para terminar-");
                n = int.Parse(Console.ReadLine());


            }
                Console.WriteLine("El maximo PAR es: " + maxPar + " , el minimo PRIMO es: " + minPrimo + " y la cantidad de IMPARES es: " + conI);

            

            


          
          
        }

   static int par (int n){
            if (n % 2 == 0)
            {
               return 1;
            }else
            {
               return 0;
            }
        }

        static int primo (int n){
            int contador = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
                {
                    return 1;
                }else{
                    return 0;
                }
        }
        




    }
}
