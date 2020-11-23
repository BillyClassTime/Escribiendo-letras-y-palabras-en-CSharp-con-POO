using System;
namespace LetrasPOO
{
    public enum NombreLetra {A, B, C, D, E, F, G, H, I, J, K, L, M, N, Ñ, O, P, Q, R, S, T, U, V, W, X, Y, Z, Á}
    public abstract class Letra
    {
        protected const sbyte SIETE = 7;
        protected const char Asterisco = '*';
        protected const char Blanco = ' ';
        protected const sbyte Length = SIETE;
        protected char[,] matrizLetra = new char[SIETE, SIETE];
        public abstract NombreLetra Nombre { get; }
        public char[,] MatrizLetra => matrizLetra; // solo get 
        public Letra() // En el constructor de la clase abstracta carga una matriz en blanco de 7x7
        {
            for (var row = 0; row < SIETE; row++)
            {
                for (var col = 0; col < SIETE; col++)
                {
                    matrizLetra[row, col] = Blanco;
                }
            }
        }
    }
    #region Diccionario de letras
    public class A : Letra
    {
        public override NombreLetra Nombre => NombreLetra.A;
        public A()
        {
            //Sergio
            matrizLetra = new char[SIETE, SIETE]{
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
        public override NombreLetra Nombre => NombreLetra.B;
        public B()
        {
            for (var i = 0; i < SIETE; i++)
            {
                //recorremos horizontal
                for (var j = 0; j < SIETE; j++)
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
        public override NombreLetra Nombre => NombreLetra.C;
        public C()
        {
            matrizLetra = new char[SIETE, SIETE] {
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
        public override NombreLetra Nombre => NombreLetra.D;
        public D()
        {
            string[] letr = new string[SIETE];
            letr[0] = "****** ";
            letr[1] = "*     *";
            letr[2] = "*     *";
            letr[3] = "*     *";
            letr[4] = "*     *";
            letr[5] = "*     *";
            letr[6] = "****** ";

            // AÑADIDO:
            // Pasamos el array de una dimensión al de dos dimensiones.
            for (var row = 0; row < SIETE; row++)
            {
                for (var col = 0; col < SIETE; col++)
                {
                    matrizLetra[row, col] = Convert.ToChar(letr[row].Substring(col, 1));
                }
            }
        }
    }
    public class E: Letra
    {
        // Version Inicial de Luis Miguel
        public override NombreLetra Nombre => NombreLetra.E;
        public E()
        {
            matrizLetra = new char[SIETE, SIETE] {
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
        public override NombreLetra Nombre => NombreLetra.F;
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
        public override NombreLetra Nombre => NombreLetra.G;
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
        public override NombreLetra Nombre => NombreLetra.H;
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
        public override NombreLetra Nombre => NombreLetra.I;
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
        public override NombreLetra Nombre => NombreLetra.J;
        public J()
        {
            matrizLetra = new char[SIETE, SIETE] {
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
        public override NombreLetra Nombre => NombreLetra.K;
        public K()
        {
            char[] miLetra = new char[49];
            for (int h = 0; h < 49; h++)
            {
                miLetra[h] = Blanco;
            }
            int f = 0, c = 1, paso = 2, index = 5, conteo = 0;
            while (f < SIETE)
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
            // Pasar el array de 1 dimensión de René miLetra[49] al array de 2 dimensiones matrizLetra[SIETE,SIETE].
            // En el caso de la K, sólo se usan las cinco primeras columnas.
            var i = 0;
            for (var fila = 0; fila < SIETE; fila++)
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
        public override NombreLetra Nombre => NombreLetra.L;
        public L()
        {
            for (var i = 0; i < SIETE; i++)
            {
                matrizLetra[i, 0] = '*';
                matrizLetra[6, i] = '*';
            }
        }
    }
    public class M : Letra
    {
        public override NombreLetra Nombre => NombreLetra.M;
        public M()
        {
            matrizLetra = new char[SIETE, SIETE] {  {'*',' ',' ',' ',' ',' ','*'},
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
        public override NombreLetra Nombre => NombreLetra.N;
        public N()
        {
            string[] letr = new string[SIETE];
            letr[0] = "*     *";
            letr[1] = "**    *";
            letr[2] = "* *   *";
            letr[3] = "*  *  *";
            letr[4] = "*   * *";
            letr[5] = "*    **";
            letr[6] = "*     *";

            // AÑADIDO:
            // Pasamos el arrays de una dimensión al de dos dimensiones.
            for (var row = 0; row < SIETE; row++)
            {
                for (var col = 0; col < SIETE; col++)
                {
                    matrizLetra[row, col] = Convert.ToChar(letr[row].Substring(col, 1));
                }
            }
        }
    }
    public class Ñ : Letra
    {
        public override NombreLetra Nombre => NombreLetra.Ñ;
        public Ñ()
        {
            for (var i = 0; i < SIETE; i++)
            {
                matrizLetra[0, i] = '*';
            }
            for (var i = 2; i < SIETE; i++)
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
        public override NombreLetra Nombre => NombreLetra.O;
        public O()
        {
            // JUSTO
            matrizLetra = new char[SIETE, SIETE] {  {' ',' ','*','*','*',' ',' '},
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
        public override NombreLetra Nombre => NombreLetra.P;
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
        public override NombreLetra Nombre => NombreLetra.Q;
        public Q()
        {
            // Justo
            matrizLetra = new char[SIETE, SIETE] {
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
        public override NombreLetra Nombre => NombreLetra.R;
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
        public override NombreLetra Nombre => NombreLetra.S;
        public S()
        {
            // Juanjo
            for (var i = 0; i < SIETE; i++)
            {
                for (var j = 0; j < SIETE; j++)
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
        public override NombreLetra Nombre => NombreLetra.T;
        public T()
        {
            // Jose Vicente
            for (var i = 0; i < Length; i++)
            {
                matrizLetra[0, i] = Asterisco;
                matrizLetra[i, 3] = Asterisco;
            }
        }
    }
    public class U : Letra
    {
        public override NombreLetra Nombre => NombreLetra.U;
        public U()
        {
            // Ino
            matrizLetra = new char[SIETE, SIETE] {
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
        public override NombreLetra Nombre => NombreLetra.V;
        public V()
        {
            //Javier
            for (var row = 0; row < SIETE; row++)
            {
                for (var column = 0; column < SIETE; column++)
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
        public override NombreLetra Nombre => NombreLetra.W;
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
            // Pasar el array de 1 dimensión de René miLetra[49] al array de 2 dimensiones matrizLetra[SIETE,SIETE].
            var i = 0;
            for (var fila = 0; fila < SIETE; fila++)
            {
                for (col = 0; col < SIETE; col++)
                {
                    matrizLetra[fila, col] = miLetra[i++];
                }
            }
        }
    }
    public class X : Letra
    {
        public override NombreLetra Nombre => NombreLetra.X;
        public X()
        {
            // Ino
            matrizLetra = new char[SIETE, SIETE] {
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
        public override NombreLetra Nombre => NombreLetra.Y;
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
            for (var i = 3; i < SIETE; i++)
                matrizLetra[i, 3] = '*';
        }
    }
    public class Z : Letra
    {
        public override NombreLetra Nombre => NombreLetra.Z;
        public Z()
        {
            for (var row = 0; row < SIETE; row++)
            {
                for (var column = 0; column < SIETE; column++)
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
    public class Á : Letra
    {
        public override NombreLetra Nombre => NombreLetra.Á;
        public Á()
        {   // Billy Vanegas 31 Oct 2020
            matrizLetra = new char[SIETE, SIETE]{
            {Blanco,Blanco,Blanco,Blanco,Asterisco,Asterisco,Asterisco},
            {Blanco,Blanco,Blanco,Asterisco,Blanco,Blanco,Blanco},
            {Blanco,Blanco,Asterisco,Blanco,Asterisco,Blanco,Blanco},
            {Blanco,Asterisco,Blanco,Blanco,Blanco,Asterisco,Blanco},
            {Blanco,Asterisco,Asterisco,Asterisco,Asterisco,Asterisco,Blanco},
            {Blanco,Asterisco,Blanco,Blanco,Blanco,Asterisco,Blanco},
            {Blanco,Asterisco,Blanco,Blanco,Blanco,Asterisco,Blanco}};
        }
    }
    #endregion
}