using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 1

            Console.WriteLine("Masukkan Tanggal Lahir Anda : ");
            string tanggalLahir = Console.ReadLine();
            Console.WriteLine(tanggalLahir);


            Console.WriteLine("Masukkan bulan lahir Anda : ");
            string bulan = Console.ReadLine();
            Console.WriteLine(bulan);


            Console.WriteLine("Masukkan tahun lahir Anda : ");
            string tahunLahir = Console.ReadLine();
            Console.WriteLine(tahunLahir);

            Console.WriteLine("Masukkan Nama Anda : ");
            string nama = Console.ReadLine();
            Console.WriteLine(nama);


            int parseToIntTahunLahir = Int32.Parse(tahunLahir);
            int parseToIntBulanLahir = Int32.Parse(bulan);
            int parseToIntTanggal = Int32.Parse(tanggalLahir);
            DateTime ulangTahun = new DateTime(parseToIntTahunLahir, parseToIntBulanLahir, parseToIntTanggal);
            DateTime HariIni = DateTime.Now;

            TimeSpan Umur = HariIni - ulangTahun;
            Console.WriteLine(" Jadi umur Anda adalah : "+Umur.TotalDays/366);

            Console.WriteLine("------------------------------------------------------------------------------------------------");


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //QUESTION 2
            Console.WriteLine("System akan menghitung (X + Y) * (Z / 2)");
            Console.WriteLine("");
            Console.WriteLine("Input value X dalam bilangan bulat: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input value Y dalam bilangan bulat: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input value z dalam bilangan desimal: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double hasil = ((double)x + (double)y) * (z / 2);
            Console.WriteLine("Hasilnya adalah {0}", hasil);

            Console.WriteLine("Ubah value X menjadi: ");
            x = Convert.ToInt32(Console.ReadLine());
            double hasil2 = ((double)x + (double)y) * (z / 2);
            Console.WriteLine("Hasilnya sekarang adalah {0}", hasil2);

            Console.WriteLine("Ubah value Y menjadi: ");
            y = Convert.ToInt32(Console.ReadLine());
            double hasil3 = ((double)x + (double)y) * (z / 2);
            Console.WriteLine("Hasilnya sekarang adalah {0}", hasil3);

            Console.WriteLine("Ubah value Z menjadi: ");
            z = Convert.ToDouble(Console.ReadLine());
            double hasil4 = ((double)x + (double)y) * (z / 2);
            Console.WriteLine("Hasilnya sekarang adalah {0}", hasil4);

            ////////////////////////////////////////QUESTION 3/////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Masukkan nama provinsi: ");
            string namaProvinsi = Console.ReadLine();
            Console.WriteLine("Masukkan nama seseorang: ");
            string namaUser = Console.ReadLine();
            Console.WriteLine("Masukkan tanggal: ");
            string tgl = Console.ReadLine();
            Console.WriteLine("Masukkan bulan: ");
            string bln = Console.ReadLine();
            Console.WriteLine("Masukkan tahun: ");
            string thn = Console.ReadLine();

            DateTime format = new DateTime(Convert.ToInt32(thn), Convert.ToInt32(bln), Convert.ToInt32(tgl));
            string formatTgl = format.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("id-ID"));
            Console.WriteLine("On {0}, The Reign of chaos has begun in the {1}. The warrior named {2} rise from the west tribe.", formatTgl, namaProvinsi, namaUser);
        }
    }
}
