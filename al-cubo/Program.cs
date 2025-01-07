using System;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, elevado;

            Console.WriteLine("Bienvenido");
            Console.WriteLine("ingrese un numero para elevarlo al cubo magicamente :O");
            n1 = int.Parse (Console.ReadLine());
            elevado = n1 * n1 * n1 ;
            Console.WriteLine("La elevado al cubo magicamente es " + elevado);
            Console.WriteLine("Gracias por usar mi programa :p");



        }
    }
}
