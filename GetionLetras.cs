using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Console;
using System.IO;
namespace LetrasPOO
{
  public abstract class Gestion
    {
        protected char Blanco = ' ';
        protected sbyte SIETE = 7;
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
            PersistirLetras pl = new PersistirLetras();
            try
            {
                if (File.Exists(pl.FilePath))
                {
                    letras = pl.DesSereliazarLetras();
                    if (letras == null)
                        letras = new Dictionary<char, Letra>();
                }
                //Carga letras en el diccionario genérico de letras
                cargarDiccionarioDeLetras();
                pl.SerializarLetras(letras); // persiste el diccionario a disco

            }
            catch (System.Exception e)
            {
                cargarDiccionarioDeLetras();
                WriteLine($"Problemas con el diccionario en disco:{e.Message.Substring(0, 24)}");
            }
        }

        private void cargarDiccionarioDeLetras()
        {
            if (letras == null)
                letras = new Dictionary<char, Letra>();
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
                for (int i = 0; i < SIETE; i++)
                {
                    for (int j = 0; j < SIETE; j++)
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
            for (sbyte lineas = 0; lineas < SIETE; lineas++) //Itera por lineas
            {   //Por cada linea itera por palabras
                for (sbyte letraPorPalabra = 0; letraPorPalabra < (sbyte)frase.Length; letraPorPalabra++)
                {
                    for (sbyte columna = 0; columna < SIETE; columna++)
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
                WriteLine();               // salto de linea
            }
        }
        public override void lecturaTeclado(string mensaje, out string lectura)
        {
            Write(mensaje);
            lectura = ReadLine();
        }

    }
}