using System;

namespace vectoreje1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
           //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
        int[] num = new int [10];
        int max = num[0];
        int pos = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero");
            num[x] = int.Parse(Console.ReadLine());
        }
 

        for (int x = 0; x < 10; x++)
        {
            if (num[x] >= max)
            {
                max = num[x];
                pos++;
            }
        }
        Console.WriteLine("El maximo es " + max);
        Console.WriteLine("y su posicion es " + pos);
    










        }
    }
}
