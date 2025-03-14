using System;
using System.Collections.Generic;

namespace modul4_2311104046
{
    class KodeBuah
    {
        private static readonly Dictionary<string, string> kodeBuahTable = new Dictionary<string, string>
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

        public static string getKodeBuah(string namaBuah)
        {
            if (kodeBuahTable.ContainsKey(namaBuah))
            {
                return kodeBuahTable[namaBuah];
            }
            else
            {
                return "Buah tidak ditemukan";
            }
        }
    }
}