using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS
{
    class Dosen
    {
        private static int nextId = 1;
        public int Id { get; private set; }
        public string Nama { get; private set; }
        public int Nik { get; private set; }
        public string Gender { get; set; }
        public List<string> Courses { get; private set; }

        public Dosen()
        {
            Id = nextId;
            nextId++;
            Nama = "Dosen Pengampu";
            Nik = 123123123;
            Gender = "Male";
            Courses = new List<string> { "Pemerograman" };
        }

        public void attDosen(string nama, int nik)
        {
            Nama = nama;
            Nik = nik;
        }

        public void addCourse(string course)
        {
            Courses.Add(course);
        }

        public void display()
        {
            Console.WriteLine($"ID     : {Id}");
            Console.WriteLine($"Nama   : {Nama}");
            Console.WriteLine($"NIK    : {Nik}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Mata Kuliah yang Diampu: {string.Join(", ", Courses)}");
        }
    }
}
