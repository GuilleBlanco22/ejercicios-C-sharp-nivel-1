using System;

namespace decreciente
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa para ingresar 4 números. Luego analizar e informar 
           // por pantalla si los mismos se encuentran ordenados de forma decreciente .

           int a, b, c, d;

           Console.WriteLine("ingrese primero numero");
           a = int.Parse (Console.ReadLine());
           Console.WriteLine("ingrese segundo numero");
           b = int.Parse (Console.ReadLine());
           Console.WriteLine("ingrese tercer numero");
           c = int.Parse (Console.ReadLine());
           Console.WriteLine("ingrese cuarto numero");
           d = int.Parse (Console.ReadLine());


           if (a > b && b > c && c > d){
            Console.WriteLine("Los numero estan ordenados de mayor a menor.");
           }
           Console.WriteLine("Fin del programa");
        }
    }
}
