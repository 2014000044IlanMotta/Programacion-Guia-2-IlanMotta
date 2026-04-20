internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese algun digito o Vocal:");
        char c = Console.ReadLine()[0];


        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("Es una vocal");
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Es un dígito");
                break;
            default:
                Console.WriteLine("No es vocal ni dígito");
                break;
        }
    }
}