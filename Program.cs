using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4388
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Karyawan 1
            Karyawan kar1 = new Karyawan();

            //set nilai
            kar1.Nik = "21.11.4388";
            kar1.Nama = "Oxa";
            kar1.GajiBulanan = 3000000;

            Console.WriteLine(); // baris kosong

            // Membuat objek Karyawan 2
            Karyawan kar2 = new Karyawan();
            kar2.Nik = "21.22.4388";
            kar2.Nama = "Defrizal";
            kar2.GajiBulanan = -3000000;
            
            if (kar1.GajiBulanan < 0) 
            {
                kar1.GajiBulanan = 0; // validasi karawan 1 = 0
            }
            if (kar2.GajiBulanan < 0)
            {
                kar2.GajiBulanan = 0; // validasi karawan 2 = 0
            } 
            Console.WriteLine(); // baris kosong

            //pemanggilan method
            Console.WriteLine("No.Nik\t      Nama\tGaji Bulanan");
            Console.WriteLine("================================");
            Console.WriteLine("1. {0} {1}\t{2}", kar1.Nik, kar1.Nama, kar1.GajiBulanan);
            Console.WriteLine("2. {0} {1}\t{2}", kar2.Nik, kar2.Nama, kar2.GajiBulanan);
            
            if (kar1.GajiBulanan >= 0)
            {
                kar1.GajiBulanan += kar1.GajiBulanan * 10 / 100; // proses menghitung bunga kar1
            }
            if (kar2.GajiBulanan >= 0)
            {
                kar2.GajiBulanan += kar2.GajiBulanan * 10 / 100; // proses menghitung bunga kar2
            }
            Console.WriteLine("\n"); // baris kosong
            Console.WriteLine("SELAMAT MENDAPATKAN NAIK GAJI");
            Console.WriteLine("---------SEBESAR 10%--------");
            Console.WriteLine("1. {0} {1}\t{2}", kar1.Nik, kar1.Nama, kar1.GajiBulanan);
            Console.WriteLine("2. {0} {1}\t{2}", kar2.Nik, kar2.Nama, kar2.GajiBulanan);
            Console.ReadKey();        
        }
    }
}
