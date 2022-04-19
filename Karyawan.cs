using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4388
{
    class Karyawan
    {   
        // constructor
        public Karyawan()
        {

        }
        // constructor dengan 3 parameter
        public Karyawan(string nik,string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
        }
        // Properties
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
    }  
}
