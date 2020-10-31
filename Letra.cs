using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Console;
namespace LetrasPOO
{
    public enum NombreLetra { A, B, C, D, E, F, G, H, I, J, K, L, M, N, Ñ, O, P, Q, R, S, T, U, V, W, X, Y, Z }
    public abstract class Letra
    {
        protected const sbyte SIETE = 7;
        protected const char Asterisco = '*';
        protected const char Blanco = ' ';
        protected const sbyte Length = SIETE;
        public abstract NombreLetra Nombre { get; }
        public abstract char[,] MatrizLetra { get; }
    }

    public class A : Letra
    {
        // varsion Inicial de Sergio
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.A;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public A()
        {
            matrizLetra = new char[7, 7]{
            {Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco}};
        }

    }
    public class B : Letra
    {
        // Version Inicial de Juanjo
        private char[,] matrizLetra = new char[7, 7];
        public override NombreLetra Nombre => NombreLetra.B;
        public override char[,] MatrizLetra => matrizLetra;
        public B()
        {

            for (var i = 0; i < 7; i++)
            {
                //recorremos horizontal
                for (var j = 0; j < 7; j++)
                {
                    matrizLetra[i, j] = (
                            (((i == 0 || i == 6) && j < 4)
                            ||
                            ((i == 1 || i == 5 || i == 2) && (j == 0 || j == 3))
                            ||
                            ((i == 3 || i == 4) && (j == 0 || j == 2))) ? Asterisco : Blanco
                    );
                }
            }
        }
    }
    public class C : Letra
    {
        // Version Inicial de Justo
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.C;
        public override char[,] MatrizLetra => matrizLetra;
        public C()
        {
            matrizLetra = new char[7, 7] {
                        {Blanco,Blanco,Asterisco,Asterisco,Asterisco,Asterisco,Blanco},
                        {Blanco,Asterisco,Blanco,Blanco,Blanco,Blanco,Asterisco},
                        {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Blanco},
                        {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Blanco},
                        {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Blanco},
                        {Blanco,Asterisco,Blanco,Blanco,Blanco,Blanco,Asterisco},
                        {Blanco,Blanco,Asterisco,Asterisco,Asterisco,Asterisco,Blanco}};
        }
    }

    public class D : Letra
    {
        // Version Inicial de Miguel Angel
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.D;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public D()
        {
            string[] letr = new string[7];
            letr[0] = "****** ";
            letr[1] = "*     *";
            letr[2] = "*     *";
            letr[3] = "*     *";
            letr[4] = "*     *";
            letr[5] = "*     *";
            letr[6] = "****** ";

            // AÑADIDO:
            // Pasamos el array de una dimensión al de dos dimensiones.
            for (var row = 0; row < 7; row++)
            {
                for (var col = 0; col < 7; col++)
                {
                    matrizLetra[row, col] = Convert.ToChar(letr[row].Substring(col, 1));
                }
            }
        }

    }
    public class E : Letra
    {
        // Version Inicial de Luis Miguel
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.E;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public E()
        {
            matrizLetra = new char[7, 7] {
              {Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco}
            , {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Blanco}
            , {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Blanco}
            , {Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Blanco,Blanco}
            , {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Blanco}
            , {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Blanco}
            , {Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco}};
        }

    }
    public class F : Letra
    {
        // Version Inicial de Carola
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.F;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public F()
        {
            for (var row = 0; row < Length; row++)
            {
                for (var column = 0; column < Length; column++)
                {
                    matrizLetra[row, column] = (
                        row == 0 ||
                        row == 3 ||
                        column == 0
                        ? Asterisco : Blanco);
                }
            }
        }

    }
    public class G : Letra
    {
        // Version Inicial de Carola
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.G;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public G()
        {
            for (var row = 0; row < Length; row++)
            {
                for (var column = 0; column < Length; column++)
                {
                    matrizLetra[row, column] = (
                        column == 0 ||
                        (column == 6 && row > 2) ||
                        (row == 3 && column > 3) ||
                        row == 0 ||
                        row == 6
                        ? Asterisco : Blanco);
                }
            }
        }

    }
    public class H : Letra
    {
        // Version Inicial de Carola
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.H;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public H()
        {
            for (var row = 0; row < Length; row++)
            {
                for (var column = 0; column < Length; column++)
                {
                    matrizLetra[row, column] = (
                        row == 3 ||
                        column == 0 ||
                        column == 6
                        ? Asterisco : Blanco);
                }
            }
        }

    }
    public class I : Letra
    {
        // Carlos
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.I;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public I()
        {
            for (var row = 0; row < Length; row++)
            {
                for (var column = 0; column < Length; column++)
                {
                    matrizLetra[row, column] = (
                    (((row == 0) && (column > 0 && column < 6)) ||
                    (column == 3) ||
                    ((row == 6) && (column > 0 && column < 6)))
                    ? Asterisco : Blanco);
                }
            }
        }

    }
    public class J : Letra
    {
        // Sergio
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.J;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public J()
        {
            matrizLetra = new char[7, 7] {
            {Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco},
            {Blanco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Blanco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Blanco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Blanco,Asterisco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Blanco,Blanco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco}};
        }

    }
    public class K : Letra
    {
        // René y Sergio
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.K;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public K()
        {
            char[] miLetra = new char[49];
            for (int h = 0; h < 49; h++)
            {
                miLetra[h] = Blanco;
            }
            int f = 0, c = 1, paso = 2, index = 5, conteo = 0;
            while (f < 7)
            {
                miLetra[conteo] = Asterisco;
                //Console.Write("*");
                conteo++;
                while (c < 5)
                {
                    if (c == (index - 1) && (f < 4))
                    {
                        miLetra[conteo] = Asterisco;
                        //Console.Write("*");
                        conteo++;
                    }
                    else if (f > 3)
                    {
                        if ((f - paso) == c)
                        {
                            miLetra[conteo] = Asterisco;
                            //Console.Write("*");
                            conteo++;
                        }
                        else
                        {
                            miLetra[conteo] = Blanco;
                            //Console.Write(" ");
                            conteo++;
                        }
                    }
                    else
                    {
                        miLetra[conteo] = Blanco;
                        //Console.Write(" ");
                        conteo++;
                    }
                    c++;
                }
                index--;
                c = 1;
                //Console.Write("\n");
                f++;
            }

            // AÑADIDO:
            // Pasar el array de 1 dimensión de René miLetra[49] al array de 2 dimensiones matrizLetra[7,7].
            // En el caso de la K, sólo se usan las cinco primeras columnas.
            var i = 0;
            for (var fila = 0; fila < 7; fila++)
            {
                for (var col = 0; col < 5; col++)
                {
                    matrizLetra[fila, col] = miLetra[i++];
                }
            }
        }

    }
    public class L : Letra
    {
        // Jose vicente
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.L;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public L()
        {
            matrizLetra = new char[7, 7]{
            {Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco},
            {Asterisco,Blanco,Blanco,Blanco,Blanco,Blanco,Asterisco}};
        }

    }
    public class M : Letra
    {
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.M;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public M()
        {
            matrizLetra = new char[7, 7] {  {'*',' ',' ',' ',' ',' ','*'},
            {'*','*',' ',' ',' ','*','*'},
            {'*',' ','*',' ','*',' ','*'},
            {'*',' ',' ','*',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'}};
        }

    }
    public class N : Letra
    {
        // Miguel Angel Sergio
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.N;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public N()
        {
            string[] letr = new string[7];
            letr[0] = "*     *";
            letr[1] = "**    *";
            letr[2] = "* *   *";
            letr[3] = "*  *  *";
            letr[4] = "*   * *";
            letr[5] = "*    **";
            letr[6] = "*     *";

            // AÑADIDO:
            // Pasamos el arrays de una dimensión al de dos dimensiones.
            for (var row = 0; row < 7; row++)
            {
                for (var col = 0; col < 7; col++)
                {
                    matrizLetra[row, col] = Convert.ToChar(letr[row].Substring(col, 1));
                }
            }
        }

    }
    public class Ñ : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.Ñ;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public Ñ()
        {
            for (var i = 0; i < 7; i++)
            {
                matrizLetra[0, i] = '*';
            }
            for (var i = 2; i < 7; i++)
            {
                matrizLetra[i, 0] = '*';
                matrizLetra[i, 6] = '*';
            }
            matrizLetra[2, 1] = '*';
            matrizLetra[3, 2] = '*';
            matrizLetra[4, 3] = '*';
            matrizLetra[5, 4] = '*';
            matrizLetra[6, 5] = '*';
        }

    }
    public class O : Letra
    {
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.O;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public O()
        {
            // JUSTO
            matrizLetra = new char[7, 7] {  {' ',' ','*','*','*',' ',' '},
              {' ','*',' ',' ',' ','*',' '},
              {'*',' ',' ',' ',' ',' ','*'},
              {'*',' ',' ',' ',' ',' ','*'},
              {'*',' ',' ',' ',' ',' ','*'},
              {' ','*',' ',' ',' ','*',' '},
              {' ',' ','*','*','*',' ',' '}};

        }

    }
    public class P : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.P;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public P()
        {
            //Sergio
            for (var horizontal = 0; horizontal < Length; horizontal++)
            {
                for (var vertical = 0; vertical < Length; vertical++)
                {
                    matrizLetra[horizontal, vertical] = (
                        (vertical == 0 ||
                        (horizontal == 0 && vertical < 6) ||
                        (vertical == 6 && (horizontal == 1 || horizontal == 2)) ||
                        (horizontal == 3 && vertical < 6)
                        ? Asterisco : Blanco));
                }
            }
        }

    }
    public class Q : Letra
    {
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.Q;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public Q()
        {
            // Justo
            matrizLetra = new char[7, 7] {
           {' ','*','*','*','*','*',' '},
           {'*',' ',' ',' ',' ',' ','*'},
           {'*',' ',' ',' ',' ',' ','*'},
           {'*',' ',' ',' ',' ',' ','*'},
           {'*',' ',' ',' ',' ',' ','*'},
           {'*',' ',' ',' ',' ','*',' '},
           {' ','*','*','*','*',' ','*'}};
        }

    }
    public class R : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.R;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public R()
        {
            // Carlos
            for (var row = 0; row < Length; row++)
            {
                for (var column = 0; column < Length; column++)
                {
                    matrizLetra[row, column] = (
                    (column == 0) ||
                    ((row == 0 || row == 4) && column < 4) ||
                    (column == 4 && (row == 0 || row == 3 || row == 5)) ||
                    (column == 5 && (row == 1 || row == 2 || row == 6))
                    ? Asterisco : Blanco);
                }
            }
        }

    }
    public class S : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.S;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public S()
        {
            // Juanjo
            for (var i = 0; i < 7; i++)
            {
                for (var j = 0; j < 7; j++)
                {
                    matrizLetra[i, j] = (
                    (((i == 0 || i == 6) && (j < 3))
                        || ((i == 1 || i == 2) && (j == 0))
                        || (i == 3 && j == 1)
                        || ((i == 4 || i == 5) && (j == 2))) ? Asterisco : Blanco
                    );
                }
            }
        }

    }
    public class T : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.T;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public T()
        {
            // Jose Vicente
            for (var i = 0; i < Length; i++)
            {
                matrizLetra[0, i] = '*';
                matrizLetra[i, 3] = '*';
            }
        }

    }
    public class U : Letra
    {
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.U;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public U()
        {
            // Ino
            matrizLetra = new char[7, 7] {
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*','*','*','*','*','*','*'}};
        }

    }
    public class V : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.V;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public V()
        {
            //Javier
            for (var row = 0; row < 7; row++)
            {
                for (var column = 0; column < 7; column++)
                {
                    matrizLetra[row, column] = (
                    (column == 0 || column == 6) && (row == 0 || row == 1) ? '*' :
                    (column == 1 || column == 5) && (row == 2 || row == 3) ? '*' :
                    (column == 2 || column == 4) && (row == 4 || row == 5) ? '*' :
                    (column == 3) && (row == 6) ? '*' : ' ');
                }
            }
        }

    }
    public class W : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.W;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public W()
        {
            // Rene y Javier
            char[] miLetra = new char[49];
            var row = 0;
            var col = 0;
            var step = 0;
            var ind = 5;
            var count = 0;
            while (row < Length)
            {
                while (col < Length)
                {
                    if (((col == 0) || (col == 3) || (col == 6)) && (row < 5))
                    {
                        miLetra[count] = '*';
                        //Console.Write("*");
                        count++;
                    }
                    else if ((row == 5) && (step == col))
                    {
                        miLetra[count] = '*';
                        //Console.Write("*");
                        count++;
                        step = step + 2;
                    }
                    else if ((row == 6) && ((col == 1) || (col == 5)))
                    {
                        miLetra[count] = '*';
                        //Console.Write("*");
                        count++;
                        step = step + 2;
                    }
                    else
                    {
                        miLetra[count] = ' ';
                        //Console.Write(" ");
                        count++;
                    }
                    col++;
                }
                ind--;
                col = 0;
                //Console.Write("\n");
                row++;
            }

            // AÑADIDO:
            // Pasar el array de 1 dimensión de René miLetra[49] al array de 2 dimensiones matrizLetra[7,7].
            var i = 0;
            for (var fila = 0; fila < 7; fila++)
            {
                for (col = 0; col < 7; col++)
                {
                    matrizLetra[fila, col] = miLetra[i++];
                }
            }
        }

    }
    public class X : Letra
    {
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.X;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public X()
        {
            // Ino
            matrizLetra = new char[7, 7] {
            {'*',' ',' ',' ',' ',' ','*'},
            {' ','*',' ',' ',' ','*',' '},
            {' ',' ','*',' ','*',' ',' '},
            {' ',' ',' ','*',' ',' ',' '},
            {' ',' ','*',' ','*',' ',' '},
            {' ','*',' ',' ',' ','*',' '},
            {'*',' ',' ',' ',' ',' ','*'}};
        }

    }
    public class Y : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.Y;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public Y()
        {
            // Juan Ramon
            matrizLetra[0, 0] = '*';
            matrizLetra[1, 1] = '*';
            matrizLetra[2, 2] = '*';
            matrizLetra[3, 3] = '*';
            matrizLetra[2, 4] = '*';
            matrizLetra[1, 5] = '*';
            matrizLetra[0, 6] = '*';
            for (var i = 3; i < 7; i++)
                matrizLetra[i, 3] = '*';
        }

    }
    public class Z : Letra
    {
        private char[,] matrizLetra = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.Z;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public Z()
        {
            for (var row = 0; row < 7; row++)
            {
                for (var column = 0; column < 7; column++)
                {
                    matrizLetra[row, column] = (
                    (column >= 0 || column <= 6) && (row == 0 || row == 6) ? '*' :
                    (column == 1 && row == 5) ? '*' : (column == 2 && row == 4) ? '*' :
                    (column == 3 && row == 3) ? '*' : (column == 4 && row == 2) ? '*' :
                    (column == 5 && row == 1) ? '*' : ' ');
                }
            }
        }

    }



    public abstract class Gestion
    {
        public abstract void PintarLetra(char letra);
        public abstract void PintarFrasePorPalabra(string frase);
        public abstract void lecturaTeclado(string mensaje, out string lectura);
    }
    public class GesLetras : Gestion
    {
        protected char Blanco = ' ';
        private Dictionary<char, Letra> letras = new Dictionary<char, Letra>();
        public Dictionary<char, Letra> Letras => letras;
        public GesLetras()
        {
            //Carga letras en el diccionario genérico de letras
            if (letras.Count < Enum.GetNames(typeof(NombreLetra)).Length)
            {
                foreach (string a in Enum.GetNames(typeof(NombreLetra)))
                {
                    if (!letras.ContainsKey(a[0]))
                    {
                        Assembly ase = typeof(Letra).Assembly;
                        Letra l = (Letra)ase.CreateInstance($"LetrasPOO.{a}");
                        letras.Add(a[0], l);
                    }
                    WriteLine(a);
                }
            }
        }
        public override void PintarLetra(char letra)
        {
            if (letras.ContainsKey(letra))
            {
                Letra l = Letras[letra];
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Write(l.MatrizLetra[i, j]);
                    }
                    WriteLine();
                }
            }
            else
                WriteLine($"Letra:{letra} - No implementada aún");
        }
        public override void PintarFrasePorPalabra(string frase)
        {
            frase = frase.ToUpper();
            for (sbyte lineas = 0; lineas < 7; lineas++) //Itera por lineas
            {   //Por cada linea itera por palabras
                for (sbyte letraPorPalabra = 0; letraPorPalabra < (sbyte)frase.Length; letraPorPalabra++)
                {
                    for (sbyte columna = 0; columna < 7; columna++)
                    {
                        if (letras.ContainsKey(frase[letraPorPalabra]))
                        {
                            Letra l = Letras[frase[letraPorPalabra]];
                            Write(l.MatrizLetra[lineas, columna]);
                        }
                        else
                            Write(Blanco); // los espacios o aquellas letras que aún no estan implementadas
                    }
                    Write(Blanco);         // espacio entre letras
                }
                WriteLine();            // salto de linea
            }
        }
        public override void lecturaTeclado(string mensaje, out string lectura)
        {
            Write(mensaje);
            lectura = ReadLine();
        }
    }
}