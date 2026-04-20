internal class Program
{
    private static void Main(string[] args)
    {
        
        
        Console.WriteLine("1-Hamburguesa");
        Console.WriteLine("2-Pizza");
        Console.WriteLine("3-Pollo frito");
        Console.WriteLine("4-Ensalada");
        Console.WriteLine("5-Salir");
        Console.WriteLine("Digite el valor segun sea la Comida: []");
        int opc = Convert.ToInt32(Console.ReadLine());
        string msj = "";
        
        switch (opc)
        {
            case 1:
                msj = "\nPidio\nHamburguesa ";
                
                break;
            case 2:
                msj = "\nPidio\nPizza ";

                break;
            case 3:
                msj = "\nPidio\nPollo Frito ";

                break;
            case 4:
                msj = "\nPidio\n Ensalada ";

                break;
            case 5:
                msj = "\nPidio\nSaliendo del sistema ";

                break;
            default:
                msj = "Digite opcion valida!!!";
                break;

        }

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(msj);
     
    }
}