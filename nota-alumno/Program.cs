using System;

namespace nota_alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, puntajeFinal;
//Ctrl + F2 = cambiar todos los valores del mismo nombre al mismo tiempo .
            Console.WriteLine("Bienvenido alumno, ingrese su calificacion del primer parcial:");

            n1 = float.Parse (Console.ReadLine());

            Console.WriteLine("Ingrese calificacion del segundo parcial:");

            n2 = float.Parse (Console.ReadLine());

            Console.WriteLine("Ingrese calificacion del tercer parcial:");

            n3 = float.Parse(Console.ReadLine());
            //para calcular promedio se suman todos los numero y se divide por la cantidad de numeros
            puntajeFinal = (n1 + n2 + n3) / 3;

            Console.WriteLine("Su calificacion final es: " + puntajeFinal.ToString("0.00"));
                                                            // .ToString("0.00") es para que escruiba solo 2 decimales y no mas 
            Console.WriteLine("Felicidades :D");


        }
    }
}
