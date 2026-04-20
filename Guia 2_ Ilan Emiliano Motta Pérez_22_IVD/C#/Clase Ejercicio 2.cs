internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba 2 valores numericos: ");
        double num1=Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("1-Suma");
        Console.WriteLine("2-Resta");
        Console.WriteLine("3-Multiplicacion");
        Console.WriteLine("4-Divicion");
        Console.WriteLine("5-Salir");
        Console.WriteLine("Digite el valor segun sea la operacion: []");
        int opc =Convert.ToInt32(Console.ReadLine());
        string msj = "";
        double result=0;
        switch (opc) {
            case 1:
                msj = "\nSUMA\nLa suma es: ";
                result= num1 + num2;
                break;
            case 2:
                msj = "\nResta\nLa Resta es: ";
                result = num1 - num2;
                break;
            case 3:
                msj = "\nMultiplicacion\nLa Multiplicacion es: ";
                result = num1 * num2;
                break;
            case 4:
                msj = "\nDivicion\nLa Divicion es: ";
                result = num1 / num2;
                break;
            case 5:
                msj = "\nSalir\nSaliendo del sistema ";
                
                break;
            default:
                msj = "Digite opcion valida!!!";
                break;

        }

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msj);
        Console.WriteLine(result);
    }
}