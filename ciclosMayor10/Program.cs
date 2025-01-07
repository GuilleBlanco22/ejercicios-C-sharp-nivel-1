using System;

namespace ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números y 
            //que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int n, nAct = 0;

            for (int i = 0; i < 10; i++){  
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            if(i == 0)
             nAct = n;
            else{  
             if (n > nAct)
               nAct = n;
            }
             }
            Console.WriteLine("El numero mas grande ingresado es: " + nAct);
        }
    }
}
