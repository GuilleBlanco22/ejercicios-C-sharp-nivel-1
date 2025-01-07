using System;

namespace funciones4
{
    class Program
    {
        static void Main(string[] args)
        {
        /*    Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba 
            un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia:
            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.*/
            int numero, estado = 0;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            pnc (numero, ref estado);

            Console.WriteLine("El estado del numero "+ numero + " es: " + estado);
        }
        static void pnc(int n, ref int estado){
            if (n > 0)
            {
                estado = 1;
            }else if (n == 0)
            {
                estado = 0;
            }else
            {
                estado = -1;
            }
        }
    }
}
