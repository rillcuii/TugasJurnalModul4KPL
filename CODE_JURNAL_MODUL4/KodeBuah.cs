using System;
using System.Collections.Generic;
using System.Text;

namespace CODE_JURNAL_MODUL4
{
    class KodeBuah
    {
        // Dictionary digunakan sebagai tabel data
        // Key = Nama buah
        // Value = Kode buah
        private Dictionary<string, string> tabelKodeBuah = new Dictionary<string, string>()
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"},
        {"Kurma", "K00"},
        {"Durian", "L00"},
        {"Anggur", "M00"},
        {"Melon", "N00"},
        {"Semangka", "O00"}
    };

        // Method untuk mengambil kode buah berdasarkan nama buah
        public string getKodeBuah(string namaBuah)
        {
            // Mengecek apakah nama buah ada di dalam tabel
            if (tabelKodeBuah.ContainsKey(namaBuah))
            {
                // Jika ada maka kembalikan kode buah
                return tabelKodeBuah[namaBuah];
            }
            else
            {
                // Jika tidak ada maka kembalikan pesan tidak ditemukan
                return "Kode buah tidak ditemukan";
            }
        }
    }
}