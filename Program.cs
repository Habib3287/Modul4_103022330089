// See https://aka.ms/new-console-template for more information

using static FanLaptop;

public class KodeProduk
{
    public String kodeProduk { get; set; }
    public String produkElektronik { get; set; }
};

public class FanLaptop {
    public enum State { quiet, balanced, performance, turbo}
}

class MainClass
{
    static void Main()
    {
        List<KodeProduk> lProduk = new List<KodeProduk> {
            new KodeProduk { produkElektronik = "Laptop", kodeProduk = "E100"},
            new KodeProduk { produkElektronik = "Smartphone", kodeProduk = "E101"},
            new KodeProduk { produkElektronik = "Tablet", kodeProduk = "E102"},
            new KodeProduk { produkElektronik = "Headset", kodeProduk = "E103"},
            new KodeProduk { produkElektronik = "Keyboard", kodeProduk = "E104"},
            new KodeProduk { produkElektronik = "Mousr", kodeProduk = "E105"},
            new KodeProduk { produkElektronik = "Printer", kodeProduk = "E106"},
            new KodeProduk { produkElektronik = "Monitor", kodeProduk = "E107"},
            new KodeProduk { produkElektronik = "Smartwatch", kodeProduk = "E108"},
            new KodeProduk { produkElektronik = "Kamera", kodeProduk = "E109"}
            };

        foreach (var data in lProduk) { 
            Console.WriteLine("Kode Produk: " + data.kodeProduk + "Produk Elektronik: " + data.produkElektronik);
        }

        Console.WriteLine("");

        FanLaptop fan = new FanLaptop();
        State stateAwal = State.quiet;
        Boolean isExit = false;

        String[] modeFan = { "QUIET", "BALANCED", "PERFORMANCE", "TURBO" };

        while (!isExit)
        {
            Console.WriteLine(modeFan[(int)stateAwal] + " MODE");
            Console.WriteLine("Change fan mode: ");

            String fanMode = Console.ReadLine().ToUpper();
            switch (stateAwal) { 
                case State.quiet:
                    if (fanMode == "MODE UP")
                    {
                        stateAwal = State.balanced;
                        Console.WriteLine("Fan Quiet berubah menjadi balanced");
                    }
                    else if (fanMode == "TURBO SHORTCUT")
                    {
                        stateAwal = State.turbo;
                        Console.WriteLine("Fan Quiet berubah menjadi turbo");
                    }
                    else if (fanMode == "EXIT")
                    {
                        Console.WriteLine("Mematikan komputer");
                        isExit = true;
                    }
                    else
                    {
                        Console.WriteLine("Inputan tidak valid");
                    }
                    break;
                case State.balanced:
                    if (fanMode == "MODE DOWN")
                    {
                        stateAwal = State.quiet;
                        Console.WriteLine("Fan Balanced berubah menjadi quiet");
                    }
                    else if (fanMode == "MODE UP")
                    {
                        stateAwal = State.performance;
                        Console.WriteLine("Fan Balanced berubah menjadi performance");
                    }
                    else if (fanMode == "EXIT")
                    {
                        Console.WriteLine("Mematikan komputer");
                        isExit = true;
                    }
                    else
                    {
                        Console.WriteLine("Inputan tidak valid");
                    }
                    break;
                case State.performance:
                    if (fanMode == "MODE DOWN")
                    {
                        stateAwal = State.balanced;
                        Console.WriteLine("Fan Performance berubah menjadi balanced");
                    }
                    else if (fanMode == "MODE UP")
                    {
                        stateAwal = State.turbo;
                        Console.WriteLine("Fan Performance berubah menjadi turbo");
                    }
                    else if (fanMode == "EXIT")
                    {
                        Console.WriteLine("Mematikan komputer");
                        isExit = true;
                    }
                    else
                    {
                        Console.WriteLine("Inputan tidak valid");
                    }
                    break;
                case State.turbo:
                    if (fanMode == "MODE DOWN")
                    {
                        stateAwal = State.performance;
                        Console.WriteLine("Fan Turbo berubah menjadi performance");
                    }
                    else if (fanMode == "TURBO SHORTCUT")
                    {
                        stateAwal = State.quiet;
                        Console.WriteLine("Fan Turbo berubah menjadi quiet");
                    }
                    else if (fanMode == "EXIT")
                    {
                        Console.WriteLine("Mematikan komputer");
                        isExit = true;
                    }
                    else
                    {
                        Console.WriteLine("Inputan tidak valid");
                    }
                    break;
            }
        }
    }
}





