using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

         
          
         
         
         /*---------------------------------------------------
         SUMAR LOS NUMEROS DE LA CIFRA
         int suma = 0; 
         int numero;
         

         Console.WriteLine("Ingrese");
         numero = int.Parse(Console.ReadLine());

         while (numero != 0)
         {
          suma += numero % 10;
          numero /= 10;
         }
         

         Console.WriteLine("La suma es " + suma);
         ------------------------------------------*/








           //tipo de dato: int, float, char, boll
          int n1, n2 , resultado;
            Console.WriteLine("Soy una Calcu =)");

          paso 1: pedir valores
          Console.WriteLine("ingrese un numero");
          n1 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese otro ");
          n2 = int.Parse(Console.ReadLine());


           //paso 2: realizar calculo
           resultado = n1 + n2;


           //paso 3: emitir resultado
           Console.WriteLine("El resultado es: " + resultado);

        }
    }
}
