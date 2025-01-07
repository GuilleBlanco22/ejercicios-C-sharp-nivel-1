using System;

namespace tresnumeros
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa para ingresar tres números y emitir 
          //  un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            int n1, n2, n3, resultado;


            Console.WriteLine("ingrese el primer numero");
            n1 = int.Parse (Console.ReadLine());
            Console.WriteLine("ingrese segundo numero");
            n2 = int.Parse (Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            n3 = int.Parse (Console.ReadLine());
            
            resultado = n1 + n2;

            if (resultado > n2 * n3){
                
                Console.WriteLine("La suma es mayor: " + resultado); 
            }
                Console.WriteLine("FIN DEL PROGRAMA");
                
            

        }
    }
}
