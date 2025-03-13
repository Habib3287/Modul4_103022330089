// See https://aka.ms/new-console-template for more information

public class KodeProduk
{
    public String kodeProduk { get; set; }
    public String produkElektronik { get; set; }
};

class MainClass
{
    static void Main()
    {
        List<KodeProduk> lProduk = new List<KodeProduk>(
            new KodeProduk { produkElektronik = "Laptop", kodeProduk = "E100"},
            new KodeProduk { produkElektronik = "Smartphone", kodeProduk = "E101"},
            new KodeProduk { produkElektronik = "Tablet", kodeProduk = "E102"},
            new KodeProduk { produkElektronik = "Headset", kodeProduk = "E103"},
            new KodeProduk { produkElektronik = "Keyboard", kodeProduk = "E104"},
            new KodeProduk { produkElektronik = "Mousr", kodeProduk = "E105"},
            new KodeProduk { produkElektronik = "Printer", kodeProduk = "E106"},
            new KodeProduk { produkElektronik = "Monitor", kodeProduk = "E107"},
            new KodeProduk { produkElektronik = "Smartwatch", kodeProduk = "E108"}
            new KodeProduk { produkElektronik = "Kamera", kodeProduk = "E109"}

            );
    }
}





