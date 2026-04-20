using System;

class Program
{
    static void Main()
    {
        int cantidad, opcion;
        double precioB = 650;
        double iva = 0.12;
        double precioIVA, total, descuento = 0, totalFinal;

        precioIVA = precioB + (precioB * iva);

        Console.Write("Ingrese la cantidad de impresoras: ");
        cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione forma de pago:");
        Console.WriteLine("1. Efectivo (10%)");
        Console.WriteLine("2. Tarjeta de crédito (5%)");
        Console.WriteLine("3. Vale de regalo (15%)");
        opcion = int.Parse(Console.ReadLine());

        total = cantidad * precioIVA;

        
        switch (opcion)
        {
            case 1:
                descuento = total * 0.10;
                break;
            case 2:
                descuento = total * 0.05;
                break;
            case 3:
                descuento = total * 0.15;
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }

        totalFinal = total - descuento;

        Console.WriteLine("\n===== DETALLE DE COMPRA =====");
        Console.WriteLine("Cantidad de impresoras: " + cantidad);
        Console.WriteLine("Precio unitario con IVA: Q" + precioIVA);
        Console.WriteLine("Total sin descuento: Q" + total);

        switch (opcion)
        {
            case 1: 
                Console.WriteLine("Forma de pago: Efectivo"); 
                break;
            case 2: 
                Console.WriteLine("Forma de pago: Tarjeta de crédito"); 
                break;
            case 3: 
                Console.WriteLine("Forma de pago: Vale de regalo"); 
                break;
        }

        Console.WriteLine("Descuento aplicado: Q" + descuento);
        Console.WriteLine("Total a pagar: Q" + totalFinal);
    }
}