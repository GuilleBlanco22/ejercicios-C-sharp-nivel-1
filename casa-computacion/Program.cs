using System;

namespace casa_computacion
{
    class Program
    {
        static void Main(string[] args)
        {
            float facturado, masComision, totalPagado;


            Console.WriteLine("Ingrese sus ventas totales:");
            facturado = float.Parse (Console.ReadLine());
            //la F del 0.05 significa que lea el valor como float aunque sea un double
            masComision = facturado * 0.05F;
            totalPagado = masComision + 15000;
            Console.WriteLine("Su sueldo total con comisiones incluidas es: " + totalPagado);

        }
    }
}
