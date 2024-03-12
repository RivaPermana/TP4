namespace TPMODUL04
{
    internal class Program
    {
        public class DoorMachine()
        {
            public enum StateDoor
            {
                TERBUKA, TERKUNCI
            }

        }

        public class KodePos
        {
            private string[] kelurahans = { "Batununggal", "Kujangsari", "Cijarua", "Mengger", "Wates", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
            private double[] kodepos = { 40266, 40287, 40287, 40267, 40256, 40286, 40286, 40286, 40272, 40274, 40273 };
            public double getKodePos(string kelurahan)
            {
                for (int i = 0; i < kelurahans.Length; i++)
                {
                    if (kelurahans[i] == kelurahan)
                    {
                        return kodepos[i];
                    }
                }
                return -1;
            }


        }
        static void Main(string[] args)
        {
            DoorMachine.StateDoor machine = DoorMachine.StateDoor.TERKUNCI;
            Console.Write("Masukkan Perintah: BukaPintu/KunciPintu/Exit: ");
            string input = Console.ReadLine();
            while (input != "Exit")
            {
                switch (machine)
                {
                    case DoorMachine.StateDoor.TERBUKA:
                        if (input == "KunciPintu")
                        {
                            machine = DoorMachine.StateDoor.TERKUNCI;
                            Console.WriteLine("Pintu Terkunci");

                        }
                        break;
                    case DoorMachine.StateDoor.TERKUNCI:
                        if (input == "BukaPintu")
                        {
                            machine = DoorMachine.StateDoor.TERBUKA;
                            Console.WriteLine("Pintu Tidak Terkunci");

                        }
                        break;
                }
                Console.Write("Input Perintah:  ");
                input = Console.ReadLine();
            }


            KodePos kodePosObj = new KodePos();

            string[] kelurahans = { "Batununggal", "Kujangsari", "Cijarua", "Mengger", "Wates", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };

            foreach (var kelurahan in kelurahans)
            {
                double kodepos = kodePosObj.getKodePos(kelurahan);
                if (kodepos != -1)
                {
                    Console.WriteLine($"Kode pos {kelurahan}: {kodepos}");
                }
                else
                {
                    Console.WriteLine($"Kode pos untuk {kelurahan} tidak ditemukan");
                }
            }
        }
    }
}
