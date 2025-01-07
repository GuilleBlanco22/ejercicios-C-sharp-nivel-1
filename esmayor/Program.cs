using System;

namespace esmayor
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa para ingresar un número y luego se emita por pantalla un
           // cartel aclaratorio si “Es mayor a 18” o “No es mayor a 18”.
           int edad;
            Console.WriteLine("Ingresar edad:");
            edad = int.Parse(Console.ReadLine());
            
            if(edad > 18) {
                Console.WriteLine("Es mayor");
            }
            else {
                Console.WriteLine("Es menor");
            }


        }
    }
}
