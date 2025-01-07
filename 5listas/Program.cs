using System;

namespace _5listas
{
    class Program
    {
        static void Main(string[] args)
        {
           // Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
           //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
           //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int n, con, conImp, impMaximo=0, minimo, conOrdenados=0;
            double porcentajeImpares, porcentajeMaximo=0;
            bool banOrdenado;


            for (int i = 0; i < 5; i++)
            {
                con=0;
                conImp=0;
                banOrdenado = true;
                Console.WriteLine("ingrese numero");
                n = int.Parse(Console.ReadLine());
                minimo = n;

                while (n != 0)
                {
                    con++;
                    if (n % 2 != 0)
                    {
                        conImp++;
                         }
                         if (n <= minimo)
                          minimo = n;
                          else 
                          banOrdenado = false;

                    Console.WriteLine("ingrese numero");
                    n = int.Parse(Console.ReadLine());
                    
                }
                porcentajeImpares = conImp * 100 / con;
                if (porcentajeImpares > porcentajeMaximo){
                    porcentajeMaximo = porcentajeImpares;
                    impMaximo = i + 1;
                     }
                if (banOrdenado)
                 conOrdenados++;    
            }
            Console.WriteLine("el grupo mas grande de impares es el grupo: " + impMaximo);
            Console.WriteLine("la cantidad de grupos con los numeros ordenados es: " + conOrdenados);
        }
    }
}
