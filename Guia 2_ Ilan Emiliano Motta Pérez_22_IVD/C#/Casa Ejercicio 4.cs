using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione unidad de medida:");
        Console.WriteLine("1-Metros,  2-Pies,  3-Centímetros,  4-Pulgadas");
        int o = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor: ");
        double valor = double.Parse(Console.ReadLine());

        double metros = 0;
        switch (o)
        {
            case 1: metros = valor; break;
            case 2: metros = valor / 3.28; break;
            case 3: metros = valor / 100; break;
            case 4: metros = valor / 39.37; break;
        }

        Console.WriteLine("Seleccione unidad final:");
        Console.WriteLine("1 Metros  2 Pies  3 Centímetros  4 Pulgadas");
        int destino = int.Parse(Console.ReadLine());

        double resultado = 0;

        switch (destino)
        {
            case 1: resultado = metros; break;
            case 2: resultado = metros * 3.28; break;
            case 3: resultado = metros * 100; break;
            case 4: resultado = metros * 39.37; break;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}