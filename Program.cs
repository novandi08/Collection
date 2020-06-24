using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan_Harian karyawan1 = new Karyawan_Harian();
            Karyawan_Tetap karyawan2 = new Karyawan_Tetap();
            Sales karyawan3 = new Sales();

            karyawan1.nik = "19112920";
            karyawan1.nama = "Novandi Juan Putra";
            karyawan1.upahPerJam = 20000;

            karyawan1.jumlahJamKerja = 8;
            karyawan2.nik = "87304934";
            karyawan2.nama = "John Wick";
            karyawan2.gajiBulanan = 5000000;

            karyawan3.nik = "85907303";
            karyawan3.nama = "Wohn Jick";
            karyawan3.jumlahPenjualan = 400;
            karyawan3.komisi = 4000;
            List<Karyawan> listKaryawan = new List<Karyawan>();
            listKaryawan.Add(karyawan1);
            listKaryawan.Add(karyawan2);
            listKaryawan.Add(karyawan3);
            int counter = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(counter + " NIK : " + karyawan.nik + ", Nama : " + karyawan.nama + ", Gaji : " + karyawan.gaji() + " \n ");
                counter++;
            }

            Console.ReadKey();

        }
    }
}
