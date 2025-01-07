using System;

namespace casa_videojuego
{
    class Program
    {
        // Una casa de video juegos otorga un descuento dependiendo del importe de la compra 
       // realizada según los siguientes valores:
      // Si el importe es menor a ARS 1000, no hay descuento.
     // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
    // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
        static void Main(string[] args)
        {
           
           float precio;

           Console.WriteLine("Ingrese el importe");
           precio = float.Parse(Console.ReadLine());

           if(precio >= 1000){
            if(precio > 5000)
            precio = precio * 0.82F;
            else precio = precio * 0.90F;
           }
           Console.WriteLine("El importe es: " + precio);
    }
}
}