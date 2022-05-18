using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_21114505
{
    class Dosen
    {
        public int id { get; set; }
        public string nama { get; set; }
        public int Nik { get; set; }
        public string gender { get; set; }
        public string course { get; set; }

        public void dosen()
        {
            Console.WriteLine("Tahun Ajaran \t: {0}", id);
            Console.WriteLine("Nama Dosen \t: {0}", nama);
            Console.WriteLine("NIK Kuliah \t: {0}", Nik);
            Console.WriteLine("Jenis Kelamin \t: {0}", gender);
            Console.WriteLine("Mata Kuliah \t: {0}", course);
        }
        public static void attdosen(string name, int nik)
        {
            Console.WriteLine("Nama Dosen \t: {0}", name);
            Console.WriteLine("NIK Dosen \t: {0}", nik);
        }
        public static void addcourse(string course)
        {
            Console.WriteLine("Mata Kuliah \t: {0}", course);
        }
    }
}
