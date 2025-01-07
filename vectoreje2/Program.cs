using System;

namespace vectoreje2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa que solicite 5  números enteros y los guarde en un vector. 
           // Luego recorrer ese vector para calcular el promedio. 
           // Mostrar por pantalla los valores que son mayores al promedio.

           int[] numeros = new int[5];
           int acu = 0, promedio;

           for (int x = 0; x < 5; x++)
           {
            Console.WriteLine("Ingrese un numero");
            numeros[x] = int.Parse(Console.ReadLine());
            acu += numeros[x];
           }
           promedio = acu / 5;
           Console.WriteLine("El promedio es " + promedio);

           for (int x = 0; x < 5; x++)
           {
            if (numeros[x] > promedio)
            {
                Console.WriteLine("Numeros mayores al promedio " + numeros[x]);
            }
            
           }

            
        }
    }
}
