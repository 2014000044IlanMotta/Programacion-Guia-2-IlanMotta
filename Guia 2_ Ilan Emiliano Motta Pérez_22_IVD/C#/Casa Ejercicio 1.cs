internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un angulo:");
        double angulo = double.Parse(Console.ReadLine());
        double rad = angulo * Math.PI / 180;
        Console.WriteLine(" CALCULADORA FUNCIONES TRIGONOMETRICAS ");
        Console.WriteLine("*************************************");
        Console.WriteLine("Lista de Funciones Trigonometricas:");
        Console.WriteLine("1-Sen");
        Console.WriteLine("2-Cos");
        Console.WriteLine("3-Tan");
        Console.WriteLine("*************************************");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("El Seno es:");
                Console.WriteLine(Math.Sin(rad));
                break;
            case 2:
                Console.WriteLine("El Cos es:");
                Console.WriteLine(Math.Cos(rad));
                break;
            case 3:
                Console.WriteLine("El Tangente es:");
                Console.WriteLine(Math.Tan(rad));
                break;
            default:
                Console.WriteLine("Elige un numero valido");
                break;
        }
    }
}