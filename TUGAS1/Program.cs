using System;
using System.ComponentModel.Design;
namespace TUGAS1
{
    class TUGAS1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Muhamamad rasyad bagaskara/18");
            // Call the other class's method to display the steps
            Caraberangkatsalat.Show(args);
        }
    } 
    class Caraberangkatsalat
    {
        public static void Show(string[] args)
        {
            Console.WriteLine("Cara berangkat salat");
            Console.WriteLine("1. Bangun tidur");
            Console.WriteLine("2. menunggu adzan");
            Console.WriteLine("3. mensucikan diri");
            Console.WriteLine("4. Mengetahui tempat salaBerpakaian rapi");
            Console.WriteLine("5. pastikan tempat ibadah");
            Console.Write("Dimana lu salat?(Masjid/ rumah): ");
            String Tempat = Console.ReadLine()?.Trim().ToLower();
            if (Tempat == "masjid")
            {
                Console.WriteLine("Pakai sendal");
                Console.WriteLine("Otw masjid");
                Console.WriteLine("Masuk masjid");

            }
            else if (Tempat == "rumah")
            {
                Console.WriteLine("siapkan sajadah");
            }
            else
            {
                Console.WriteLine("Tempat tidak valid.");
                return;
            }
            Console.WriteLine("Laksanakan dalat subuh");
            Console.WriteLine("Selesai");

            Caramautidur.Show(args);
        }
    }
    class Caramautidur
    {
        public static void Show(string[] args)
        {
            Console.Write("Bersih-bersih dulu?(Iya/Tidak): ");
            string jawaban = Console.ReadLine()?.Trim().ToLower();
            if (jawaban == "iya")
            {
                Console.WriteLine("Pergi ke kamar mandi");
                Console.WriteLine("Sikat gigi");
                Console.WriteLine("Cuci muka");
                Console.WriteLine("Pakai baju tidur");
            }
            else if (jawaban == "tidak");
            { 
               Console.WriteLine("siapkan baju tidur");
               Console.WriteLine("Menuju kasur");

             }
            Console.Write("Scroll tiktok dulu?(Iya/Tidak): ");
            string Yeno = Console.ReadLine()?.Trim().ToLower();
            if (Yeno == "iya")
            {
                Console.WriteLine("Buka tiktok");
                Console.WriteLine("Scroll tiktok");
            }
            else if (Yeno == "tidak") ;
            {
                Console.WriteLine("langsung turu");
                

            }

            Console.WriteLine("Selamat tidur");
            Console.WriteLine("Baca doa tidur");


            Carasalatsubuh.Show (args);
        }
    }
    class Carasalatsubuh
    {
        public static void Show(string[] args)
        {
            Console.WriteLine("Cara salat subuh");
            Console.WriteLine("1. Niat salat subuh");
            Console.WriteLine("2. Takbiratul ihram");
            Console.WriteLine("3. Membaca surat Al-Fatihah");
            Console.WriteLine("4. Membaca surat pendek");
            Console.WriteLine("5. Ruku'");
            Console.WriteLine("6. I'tidal");
            Console.WriteLine("7. Sujud");
            Console.WriteLine("8. Duduk di antara dua sujud");
            Console.WriteLine("9. Sujud kedua");
            Console.WriteLine("10. Tasyahud akhir dan salam");
            Pellantai.Show(args);
        }
    }      

    class Pellantai
    {
        public static void Show(string[] args)
        {
            Console.WriteLine("Cara melantai");
            Console.Write("tuang cairan pel dilantai?(iya/tidak)");
            string jawaban = Console.ReadLine()?.Trim().ToLower();
            if (jawaban == "iya")
            {
                Console.WriteLine("Tuang cairan pel dilantai");
                Console.WriteLine("Ambil pel");
                Console.WriteLine("Pel lantai dengan gerakan maju mundur");
            }
            else if (jawaban == "tidak")
            {
                Console.WriteLine("Ambil pel");
                Console.WriteLine("Pel lantai dengan gerakan maju mundur");
            }
            else
            {
                Console.WriteLine("Jawaban tidak valid.");
                return;
            }
            Console.WriteLine("Pel lantai secara merata");
            
            Caradengerinspotify.Show(args);
        }
    }
    class Caradengerinspotify
    {
        public static void Show(string[] args)
        {
            Console.WriteLine("Cara mendengarkan spotify");
            Console.WriteLine("1. Buka aplikasi Spotify");
            Console.WriteLine("2. Login ke akun Spotify");
            Console.WriteLine("3. Cari lagu atau playlist yang ingin didengarkan");
            Console.WriteLine("4. Klik tombol play untuk memutar lagu");
            Console.WriteLine("5. Atur volume sesuai keinginan");

        }
    }
}
