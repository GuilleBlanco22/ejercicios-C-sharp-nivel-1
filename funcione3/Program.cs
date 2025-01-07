using System;

namespace funcione3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
            //Informar el promedio teniendo en cuenta sólo los números primos.
            int num, resulFuncion;
            int contador = 0, acumulador = 0;

            Console.WriteLine("Ingrese un numero, 0 para terminar");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                resulFuncion = primo(num);
                if (resulFuncion == 1)
                {
                    contador++;
                    acumulador += num;
                }
                Console.WriteLine("Ingrese un numero, 0 para terminar");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El promedio de los numeros enteros es: " + acumulador / contador);



        }
        static int primo (int n){
            int contador = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
                {
                    return 1;
                }else{
                    return 0;
                }
        }

    }
}
