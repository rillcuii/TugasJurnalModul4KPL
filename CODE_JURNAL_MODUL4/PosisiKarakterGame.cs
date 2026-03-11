using System;
using System.Collections.Generic;
using System.Text;

namespace CODE_JURNAL_MODUL4
{
    class PosisiKarakterGame
    {
        // Enum digunakan untuk menentukan kemungkinan state karakter
        enum State
        {
            Berdiri,
            Tengkurap,
            Terbang,
            Jongkok
        }

        // State awal karakter adalah berdiri
        private State currentState = State.Berdiri;

        // Method untuk mengubah state karakter
        public void UbahState(State newState)
        {
            // Mengecek perubahan state
            if (newState == State.Berdiri)
            {
                Console.WriteLine("posisi standby");
            }

            if (newState == State.Tengkurap)
            {
                Console.WriteLine("posisi istirahat");
            }

            // Mengubah state karakter
            currentState = newState;
        }

        // Method untuk mensimulasikan perubahan state
        public void Simulasi()
        {
            // Simulasi perubahan state karakter

            UbahState(State.Berdiri);
            UbahState(State.Tengkurap);
            UbahState(State.Terbang);
            UbahState(State.Jongkok);
        }
    }
}
