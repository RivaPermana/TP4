public class KodePos
{
    public enum EnumKelurahan
    {
        Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
    }

    public static int GetKodePos(EnumKelurahan kelurahan)
    {
        int[] KodePosKelurahan = { 40266, 40287, 40267, 40287, 40286, 40286, 40272, 40274, 40273 };
        return KodePosKelurahan[(int) kelurahan];
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Kelurahan & Kode Pos");
        Console.WriteLine("---------------------");
        foreach (EnumKelurahan kelurahan in Enum.GetValues(typeof(EnumKelurahan)))
        {
            Console.WriteLine($"{kelurahan} - {GetKodePos(kelurahan)}");
        }
    }
}