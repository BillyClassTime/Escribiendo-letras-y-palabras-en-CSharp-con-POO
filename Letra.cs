using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Console;
namespace LetrasPOO
{
    public enum NombreLetra { A,B,C,D,E,F,G,H,I,J,K,L,M,N,Ñ,O,P,Q,R,S,T,U,V,W,X,Y,Z }
    public abstract class Letra
    {
        public abstract NombreLetra Nombre { get; }
        public abstract char[,] MatrizLetra { get; }
    }

    public class A : Letra
    {
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.A;
        public override char[,] MatrizLetra => matrizLetra; // { get; }
        public A()
        {
            matrizLetra = new char[7, 7]{
            {'*','*','*','*','*','*','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*','*','*','*','*','*','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'},
            {'*',' ',' ',' ',' ',' ','*'}};
        }

    }
    public class B : Letra
    {
        private char[,] matrizLetra = new char[7, 7];
        public override NombreLetra Nombre => NombreLetra.B;
        public override char[,] MatrizLetra => matrizLetra;
        public B()
        {
            char pinta = '*';
            char cadena = ' ';
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
                            ((i == 3 || i == 4) && (j == 0 || j == 2))) ? pinta : cadena
                    );
                }
            }
        }
    }
    public class C : Letra
    {
        private char[,] matrizLetra; // = new char[7,7];
        public override NombreLetra Nombre => NombreLetra.C;
        public override char[,] MatrizLetra => matrizLetra;
        public C()
        {
            matrizLetra = new char[7, 7] {
                        {' ',' ','*','*','*','*',' '},
                        {' ','*',' ',' ',' ',' ','*'},
                        {'*',' ',' ',' ',' ',' ',' '},
                        {'*',' ',' ',' ',' ',' ',' '},
                        {'*',' ',' ',' ',' ',' ',' '},
                        {' ','*',' ',' ',' ',' ','*'},
                        {' ',' ','*','*','*','*',' '}};
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
            frase=frase.ToUpper();
            for (sbyte lineas = 0; lineas < 7; lineas++) //Itera por lineas
            {   //Por cada linea itera por palabras
                for (sbyte letraPorPalabra = 0; letraPorPalabra < (sbyte)frase.Length; letraPorPalabra++)
                {
                    for (sbyte columna = 0; columna < 7; columna++)
                    {
                        if (letras.ContainsKey(frase[letraPorPalabra]))
                        {
                            Letra l = Letras[frase[letraPorPalabra]];
                            Write(l.MatrizLetra[lineas,columna]);
                        }
                        else
                            Write(' '); // los espacios o aquellas letras que aún no estan implementadas
                    }
                    Write(' ');         // espacio entre letras
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