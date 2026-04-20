internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un sector:");
        
        Console.WriteLine("1-Palco(300)");
        Console.WriteLine("2-Tribuna(125)");
        Console.WriteLine("3-Preferencia(75)");
        Console.WriteLine("4-General(50)");
        double sec = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la Cantidad de entradas:");
        double can = double.Parse(Console.ReadLine());
        double a = 0;
        switch (sec)
        {
            case 1:
                Console.WriteLine("Precio: 300");
                sec = 300;
                break;
            case 2:
                Console.WriteLine("Precio: 125");
                sec = 125;
                break;
            case 3:
                Console.WriteLine("Precio: 75");
                sec = 75;
                break;
            case 4:
                Console.WriteLine("Precio: 50");
                sec = 50;
                break;
            default:
                Console.WriteLine("Elige una opcion valida!!!");
                break;
        
        }
        a = sec * can;
        Console.WriteLine("Total a pagar Q."+a);
    }
}