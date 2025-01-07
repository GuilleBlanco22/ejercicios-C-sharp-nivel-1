using System;

namespace ciclos20edades
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa que solicite 20 edades y luego calcule 
           // el promedio de edad de aquellas personas mayores a 18 años.
            int n, x, con = 0, acu = 0;

            for(x = 0; x < 20; x++){
                Console.WriteLine("Ingrese edad: ");
                n = int.Parse(Console.ReadLine());
                
                if (n > 18){ 
                con++;
                acu+= n; 
                }
            }
             Console.WriteLine("El promedio de los mayores de edad es: " + acu/con);   
        }
    }
}
