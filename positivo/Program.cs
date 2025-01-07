using System;

namespace positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo”
            //si el número es mayor a cero, “Negativo” si el número es menor a cero 
            //o “Cero” si el número es igual a cero.
            int n;
            Console.WriteLine("Ingrese numero por favor:");
            n = int.Parse(Console.ReadLine());

            if(n > 0){
                Console.WriteLine("Es POSITIVO");
            }else if(n < 0){
                Console.WriteLine("Es NEGATIVO"); 
            }else{
                Console.WriteLine("Es CERO");
            }

        }
    }
}
