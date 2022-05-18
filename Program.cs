using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_21114505
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama, course;
            int nik;

            Dosen utama = new Dosen();
            utama.id = 21;
            utama.nama = "Kamarudin, M.Kom";
            utama.Nik = 212022;
            utama.gender = "Laki-laki";
            utama.course = "Pemrograman";
            Console.WriteLine("===== DATA DOSEN DEFAULT =====");
            Console.WriteLine();
            utama.dosen();
            Console.WriteLine();
            Console.WriteLine("===== INPUT DATA DOSEN =====");
            Console.WriteLine();
            Console.Write("Masukkan Nama Dosen \t\t: ");
            nama = Console.ReadLine();
            Console.Write("Masukkan NIK Dosen \t\t: ");
            nik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Mata Kuliah Dosen \t: ");
            course = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("===== DATA DOSEN YANG SUDAH DIINPUTKAN =====");
            Console.WriteLine();
            Dosen.attdosen(nama, nik);
            Dosen.addcourse(course);

            Console.ReadKey();
        }
    }
}
