using System;
using static System.Console;
namespace LetrasPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var gl = new GesLetras();
            gl.lecturaTeclado("Entre letra:", out string lectura);
            gl.PintarFrasePorPalabra(lectura);
        }
    }
}
