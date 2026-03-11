using CODE_JURNAL_MODUL4;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek dari class KodeBuah
        KodeBuah kodeBuah = new KodeBuah();

        // Meminta user memasukkan nama buah
        Console.Write("Masukkan nama buah: ");
        string buah = Console.ReadLine();

        // Memanggil method getKodeBuah untuk mencari kode buah
        string kode = kodeBuah.getKodeBuah(buah);

        // Menampilkan hasil kode buah
        Console.WriteLine("Kode buah: " + kode);


        Console.WriteLine("\nSimulasi Posisi Karakter Game");

        // Membuat objek dari class PosisiKarakterGame
        PosisiKarakterGame karakter = new PosisiKarakterGame();

        // Memanggil simulasi perubahan state
        karakter.Simulasi();
    }
}