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
                

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
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
            Console.Clear();
            Console.WriteLine("\nPilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Hapus Data");
            Console.WriteLine("3. Tampilkan Data");
            Console.WriteLine("4. KELUAR\n");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
              // membuat instance dari class KaryawanTetap
                TambahMahasiswa tambahMahasiswa = new TambahMahasiswa();


                Console.WriteLine("Tambah Data Mahasiswa");

                // Input Data ke instance Mahasiswa
                Console.WriteLine("NIM \t\t: ");
                TambahMahasiswa.NIK = Console.ReadLine();

                Console.WriteLine("Nama \t\t: ");
                TambahMahasiswa.Nama = Console.ReadLine();

                Console.WriteLine("Jenis Kelamin [L/P] \t\t: ");
                TambahMahasiswa.Nama = Console.ReadLine();
                string JenisKelamin = Console.ReadLine();
                mahasiswa.JenisKelamin = (JenisKelamin == "L" || JenisKelamin == "P") ? "Laki Laki" : "Perempuan";

                Console.Write("IPK \t: ");
                TambahMahasiswa.IPK = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection

             // menampilkan judul menu yang dipilih
            Console.WriteLine("Hapus Data Mahasiswa");

            // insiailasi variable found
            bool found = true;

            // input nik
            string nik;
            Console.Write("\nNIM: ");
            nik = Console.ReadLine();

            // looping data karyawan
            for (int i = 0; i < Mahasiswa.Count; i++)
            {
                // seleksi jika inputan nim sama dengan pada nim  di list  mahasiswa
                if (Mahasiswa[i].NIM == nim)
                {
                    // data jika ditemukan
                    Mahasiswa.Remove(Mahasiswa[i]);
                    found = true;
                    break;
                }
                else
                {
                    // data jika tdk ditemukan
                    found = false;
                }
            }
             if (!found)
            {
                Console.WriteLine("Data tidak dengan NIM = {0} ", nim);
                Console.WriteLine("NIM tidak ditemukan");
            }
            else
            {
                Console.WriteLine("Data dengan NIM = {0} ", nim);
                Console.WriteLine("Data Mahasiswa berhasil dihapus");
            }


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

