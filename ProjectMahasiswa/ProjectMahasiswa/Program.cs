using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Mahasiswa mahasiswa = new Mahasiswa();
            Console.WriteLine("Tambah Mahasiswa \n");
            Console.Write("NIM : ");
            mahasiswa.Nim = Console.ReadLine();

            Console.Write("Nama : ");
            mahasiswa.Nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P] : ");
            mahasiswa.JenisKelamin = Console.ReadLine();
            if (mahasiswa.JenisKelamin == "L" || mahasiswa.JenisKelamin == "l")
            {
                mahasiswa.JenisKelamin = "Laki-Laki";
            }
            else if (mahasiswa.JenisKelamin == "P" || mahasiswa.JenisKelamin == "p")
            {
                mahasiswa.JenisKelamin = "Perempuan";
            }
            else
            {
                mahasiswa.JenisKelamin = "Unknown";
            }

            Console.Write("IPK : ");
            mahasiswa.Ipk = Console.ReadLine();

            daftarMahasiswa.Add( mahasiswa );


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {

            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("Data Mahasiswa\n");
            int i = 1;
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                    i, mhs.Nama, mhs.Nim, mhs.JenisKelamin, mhs.Ipk);
                i++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
