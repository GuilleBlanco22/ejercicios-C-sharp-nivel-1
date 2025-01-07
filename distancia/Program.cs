using System;

namespace distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veamos a cuanto tiempo estas de tu destino");

            float kilometros, velocidad, tiempoEstimado;

            Console.WriteLine("ingresar kilometos de su destino:");
            kilometros = float.Parse (Console.ReadLine());
            Console.WriteLine("ingrese la velocidad a la que viaja:");
            velocidad = float.Parse (Console.ReadLine());

            tiempoEstimado = kilometros / velocidad;
            Console.WriteLine ("tiempo estimado de llegada " + tiempoEstimado.ToString("0.00") + " horas");
            Console.WriteLine("Buen viaje :)");



        }
    }
}
