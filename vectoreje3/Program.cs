using System;

namespace vectoreje3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
           El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
           sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
           CADENA FUENTE: “La mar estaba serena"
           CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
           CADENA RESULTADO: “Li mir estibi sereni"*/

            /*char[] cadena = new char[30];
            char a, b, letra;
            int indice = 0;

            Console.WriteLine("Ingrese letra");
            letra = char.Parse(Console.ReadLine());

            while (letra != '.' && indice < 30)
            {
            cadena[indice] = letra;
            Console.WriteLine("Ingrese otra letra");
            letra = char.Parse(Console.ReadLine());
            indice++;
            }
            cadena[indice] = '\0';

            Console.WriteLine(" La frase completa es : ");
            indice = 0;
            while (cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
                indice++;
            }

                

            Console.WriteLine("Ingrese letra que desea cambiar");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese letra nueva");
            b = char.Parse(Console.ReadLine());

            indice = 0; 
            while (cadena[indice] != '\0')
            {
                if (cadena[indice] == a)
                {
                    cadena[indice] = b;
                }
                    indice++;
                
            }
            Console.WriteLine("La frase nueva es: ");
            indice = 0;
            while (cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
                indice++;
            }*/

            string frase;
            char letraActual;
            char letraNueva;
            Console.WriteLine("Ingrese frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese letra que desea cambiar");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese letra nueva");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual, letraNueva);

            Console.WriteLine("La frase nueva es: ");
            Console.WriteLine(frase);

            

                
            

            

            
        }
    }
}
