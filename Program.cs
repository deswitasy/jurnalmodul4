// See https://aka.ms/new-console-template for more information
using System;

class KodeProduk
{
    private static Dictionary<string, string> tabelKodeProduk = new Dictionary<string, string>
    {
        {"Laptop", "E100"},
        {"Smartphone", "E101"},
        {"Tablet", "E102"},
        {"Headset", "E103"},
        {"Keyboard", "E104"},
        {"Mouse", "E105"},
        {"Printer", "E106"},
        {"Monitor", "E107"},
        {"Smartwatch", "E108"},
        {"Kamera", "E109"}
    };

    public static string getKodeProduk(string elektronik)
    {
        if (tabelKodeProduk.ContainsKey(elektronik))
        {
            return tabelKodeProduk[elektronik];
        }
        else
        {
            return "kode produk tidak ditemukan";
        }
       
    }
}
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Masukkan nama Elektronik: ");
//        string inputElektronik = Console.ReadLine();

//        string kodeProduk = KodeProduk.getKodeProduk(inputElektronik);
//        Console.WriteLine($"kode produk untuk {inputElektronik}: {kodeProduk} ");

//    }
//}



public class FanLaptop
{
    public enum State { Quiet, Balanced, Performance, Turbo }
    public static State currentState = State.Quiet;
    string[] command = { "modeUp", "modeDown", "turboShortcut", "EXIT" };

  
    public FanLaptop()
    {
        
    }
    public static void Main(String[] args)
    {
        FanLaptop fanLaptop = new FanLaptop();
        Console.Write("Enter Command : ");
        String x = Console.ReadLine();
        while (x != "EXIT")
        {
            switch (currentState)
            {
                case State.Quiet:
                    if(x == "modeUp")
                    {
                        currentState = State.Balanced;
                        Console.WriteLine("Fan Quiet berubah menjadi balanced");
                    }
                    else if (x == "turboShortcut")
                    {
                        currentState = State.Turbo;
                        Console.WriteLine("Fan Quiet berubah menjadi balanced");
                    }
                        break;
                case State.Balanced:
                    if (x == "modeUp")
                    {
                        currentState = State.Performance;
                        Console.WriteLine("Fan Balanced berubah menjadi Performanced");
                    }
                    else if (x == "modeDown")
                    {
                        currentState = State.Quiet;
                        Console.WriteLine("Fan Balanced berubah menjadi Quiet");
                    }
                    break;
                case State.Performance:
                    if (x == "modeUp")
                    {
                        currentState = State.Turbo;
                        Console.WriteLine("Fan Performance berubah menjadi Turbo");
                    }
                    else if (x == "modeDown")
                    {
                        currentState = State.Balanced;
                        Console.WriteLine("Fan Performance berubah menjadi Balanced");
                    }
                    break;
                case State.Turbo:
                    if (x == "Turbo Shortcut")
                    {
                        currentState = State.Quiet;
                        Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                    }
                    else if (x == "modeDown")
                    {
                        currentState = State.Performance;
                        Console.WriteLine("Fan Turbo berubah menjadi Performance");
                    }
                    break;

            }
            Console.Write("Enter Command : ");
            x = Console.ReadLine();

        }
    }
    
}

     
