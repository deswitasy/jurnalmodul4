// See https://aka.ms/new-console-template for more information
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
class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama Elektronik: ");
        string inputElektronik = Console.ReadLine();

        string kodeProduk = KodeProduk.getKodeProduk(inputElektronik);
        Console.WriteLine($"kode produk untuk {inputElektronik}: {kodeProduk} ");

    }
}
