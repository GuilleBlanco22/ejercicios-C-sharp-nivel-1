using System;

namespace vectores
{
    class Program
    {
        static void Main(string[] args)
        { //VECTORES / ARRAY

        //  0 1 2 3 4 5 6 7 8 9 INDICE
        // | | | | | | |1| | | |

        //int[] nombre = new int[10]; forma de declarar un vector 
        // ej para cargar numeros en vector 
        // nombre[6] = 1;

        //otro ej de cargar numeros en vector 
        // for (int i = 0; i < 10; i++)
        // {
        //    console.WriteLine("cargue un numero");
        //    n = int.Parse(Console.ReadLine());
        //    numeros[x] = n;        
        //  }
        /*char[] nombre = new char[10];
        char letra;
        int indice = 0;

        //escribir nombre
        Console.WriteLine("ingrese nombre letra por letra...(ingrese punto para terminar)");
        letra = char.Parse(Console.ReadLine());
        while (letra != '.' && indice < 10)
        {
            nombre[indice] = letra;
            letra = char.Parse(Console.ReadLine());
            indice++;
        }
        nombre[indice] = '\0';



        //leer nombre
        Console.Write("Hola ");
        indice = 0;
        while (nombre[indice] != '\0')
        {
            Console.Write(nombre[indice]);
            indice++;
        }*/


        string nombre;
        Console.WriteLine("Ingrese su nombre ...");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola " + nombre);
       



            
        }
    }
}
