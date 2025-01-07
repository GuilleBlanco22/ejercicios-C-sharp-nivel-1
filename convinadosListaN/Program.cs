using System;

namespace convinadosListaN
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
           //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
           int n, con;

           do
           {
            con = 0;
            Console.WriteLine("ingrese los numeros");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            { 
                con++;
                Console.WriteLine("ingrese los numeros");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La lista tiene " + con + " numeros positivos ingresados");
           } while (n >= 0);

                

            
        }
    }
}
