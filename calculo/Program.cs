using System;

namespace calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un numero:");
            n1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            n2 = int.Parse (Console.ReadLine());

            if (n1 == n2) {
                resultado = n1 + n2;
                Console.WriteLine("numero sumados = " + resultado);
            }
            else if (n1 > n2){
                resultado = n1 - n2;
                Console.WriteLine("numeros restados = " + resultado);
            }
            else if (n1 < n2){
                resultado = n1 * n2;
                Console.WriteLine("numeros multiplicados = " + resultado);
            }
        }
    }
}
