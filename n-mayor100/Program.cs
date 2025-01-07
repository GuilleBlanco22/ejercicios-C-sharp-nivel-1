using System;

namespace n_mayor100
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            int a, b, c, d;

            Console.WriteLine("Ingresar numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar numero");
            d = int.Parse(Console.ReadLine());

            if(a > 100){
                Console.WriteLine("El primero valor es mayor a 100: " + a);
            }
            if(b > 100){
                Console.WriteLine("El segundo valor es mayor a 100: " + b);
            }
            if(c > 100){
                Console.WriteLine("EL tercer valor es mayor a 100: " + c);
            }
            if(d > 100){
                Console.WriteLine("El cuarto valor es mayor a 100: " + d);
            }
            //Console.WriteLine("Esos numeros son mayores a 100");
    }   }
}
