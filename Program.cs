

using Modul3_1302200097;


    class Program
    {
        // Table-Driven
        public static void Main(String[] args)
        {
            KodeBuah obj1 = new KodeBuah();
            KodeBuah.NamaBuah = KodeBuah.NamaBuah.Kurma;
            Console.WriteLine("Kode Buah : ", KodeBuah.GetKodeBuah(KodeBuah.NamaBuah));
        }

    }



