using System;

namespace nPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
             //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
             //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
             int n, x, con = 0;

            Console.WriteLine("Ingrese numero");
            n = int.Parse(Console.ReadLine());

            for(x = 1; x <= n; x ++) {
                if ( n % x == 0)
                con++;
            }
            if(con == 2)
            Console.WriteLine("Es Primo");
            else
            Console.WriteLine("No es primo");
        }
    }
}
