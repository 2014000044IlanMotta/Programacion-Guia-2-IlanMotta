internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número del 1 al 12: ");
        int num = int.Parse(Console.ReadLine());
        String result = "";
        switch (num)
        {
            case 1:
                Console.WriteLine("El mes es:");
                result = "Enero";
                Console.WriteLine(result);
                break;
            case 2:
                Console.WriteLine("El mes es:");
                result = "Febrero";
                Console.WriteLine(result);
                break;
            case 3:
                Console.WriteLine("El mes es:");
                result = "Marzo";
                Console.WriteLine(result);
                break;
            case 4:
                Console.WriteLine("El mes es:");
                result = "Abril";
                Console.WriteLine(result);
                break;
            case 5:
                Console.WriteLine("El mes es:");
                result = "Mayo";
                Console.WriteLine(result);
                break;
            case 6:
                Console.WriteLine("El mes es:");
                result = "Junio";
                Console.WriteLine(result);
                break;
            case 7:
                Console.WriteLine("El mes es:");
                result = "Julio";
                Console.WriteLine(result);
                break;
            case 8:
                Console.WriteLine("El mes es:");
                result = "Agosto";
                Console.WriteLine(result);
                break;
            case 9:
                Console.WriteLine("El mes es:");
                result = "Septiembre";
                Console.WriteLine(result);
                break;
            case 10:
                Console.WriteLine("El mes es:");
                result = "Octubre";
                Console.WriteLine(result);
                break;
            case 11:
                Console.WriteLine("El mes es:");
                result = "Noviembre";
                Console.WriteLine(result);
                break;
            case 12:
                Console.WriteLine("El mes es:");
                result = "Diciembre";
                Console.WriteLine(result);
                break;
            default:
                Console.WriteLine("Elige un numero valido");
                break;
        }
    }
}