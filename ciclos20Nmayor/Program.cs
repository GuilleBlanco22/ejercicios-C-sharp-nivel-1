using System;

namespace ciclos20Nmayot
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa que solicite 20 números y luego emitir por 
           // pantalla el máximo de los números pares y el mínimo de los números impares.
           int n, x, mayor = 0, menor = 0;
           bool banPar = false, banImpar = false;

           for (x = 0; x < 20; x++){
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            if(n % 2 == 0){  //numeros pares //bandera para que el primer numero que entra la convierta en positivo.
                if(banPar == false){
                    mayor = n;
                    banPar = true;
                }else if (n > mayor)
                mayor = n;

            }else {
                if (banImpar == false){
                    menor = n;
                    banImpar = true;
            }else if (n < menor)
            menor = n;
                
           }
           }
           Console.WriteLine("El mayor de los numeros pares es :" + mayor);
           Console.WriteLine("El menor de los numeros impares es : " + menor);

}
 }
 }