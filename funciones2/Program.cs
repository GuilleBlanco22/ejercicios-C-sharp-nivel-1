using System;

namespace funciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int n, r, contador = 0;

            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
                
            r = par (n);
            if (r == 1)
            {
                contador++;
            }
            }
            Console.WriteLine(contador + " numeros son pares.");
            



        }
        static int par (int n){
            if (n % 2 == 0)
            {
               return 1;
            }else
            {
               return 0;
            }

        }
    }
}
