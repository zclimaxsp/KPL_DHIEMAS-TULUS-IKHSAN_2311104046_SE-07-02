using System;

namespace modul4_2311104046
{
    class PosisiKarakterGame
    {
        // Enum untuk state karakter game
        enum State { Berdiri, Jongkok, Tengkurap, Terbang }

        // Menyimpan state saat ini
        private State currentState;

        // Constructor
        public PosisiKarakterGame()
        {
            currentState = State.Berdiri;
            // NIM % 3 == 1 condition
            Console.WriteLine("posisi standby");
        }

        // Method untuk tombol S (bawah)
        public void TombolS()
        {
            // NIM % 3 == 0 condition
            Console.WriteLine("tombol arah bawah ditekan");

            switch (currentState)
            {
                case State.Berdiri:
                    currentState = State.Jongkok;
                    Console.WriteLine("Posisi Berdiri -> Jongkok");
                    break;
                case State.Jongkok:
                    currentState = State.Tengkurap;
                    Console.WriteLine("Posisi Jongkok -> Tengkurap");
                    // NIM % 3 == 1 condition
                    Console.WriteLine("posisi istirahat");
                    break;
                case State.Terbang:
                    currentState = State.Berdiri;
                    Console.WriteLine("Posisi Terbang -> Berdiri");
                    // NIM % 3 == 1 condition
                    Console.WriteLine("posisi standby");
                    break;
                case State.Tengkurap:
                    Console.WriteLine("Posisi Tengkurap tidak berubah");
                    break;
            }
        }

        // Method untuk tombol W (atas)
        public void TombolW()
        {
            // NIM % 3 == 0 condition
            Console.WriteLine("tombol arah atas ditekan");

            switch (currentState)
            {
                case State.Tengkurap:
                    currentState = State.Jongkok;
                    Console.WriteLine("Posisi Tengkurap -> Jongkok");
                    break;
                case State.Jongkok:
                    currentState = State.Berdiri;
                    Console.WriteLine("Posisi Jongkok -> Berdiri");
                    // NIM % 3 == 1 condition
                    Console.WriteLine("posisi standby");
                    break;
                case State.Berdiri:
                    currentState = State.Terbang;
                    Console.WriteLine("Posisi Berdiri -> Terbang");
                    // NIM % 3 == 2 condition
                    Console.WriteLine("posisi take off");
                    break;
                case State.Terbang:
                    Console.WriteLine("Posisi Terbang tidak berubah");
                    break;
            }
        }

        // Method untuk tombol X (special action)
        public void TombolX()
        {
            switch (currentState)
            {
                case State.Terbang:
                    currentState = State.Jongkok;
                    Console.WriteLine("Posisi Terbang -> Jongkok");
                    // NIM % 3 == 2 condition
                    Console.WriteLine("posisi landing");
                    break;
                default:
                    Console.WriteLine("Tombol X tidak memiliki efek pada posisi saat ini");
                    break;
            }
        }
    }
}