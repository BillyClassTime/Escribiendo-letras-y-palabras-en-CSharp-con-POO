using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace LetrasPOO
{
    public class PersistirLetras
    {
        private string filePath = @".\Letras.json";
        public string FilePath => filePath;
        public void SerializarLetras(Dictionary<char, Letra> letras)
        {
            string json = JsonConvert.SerializeObject(letras, Formatting.Indented,
            new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                TypeNameAssemblyFormatHandling = 0
            });
            File.WriteAllText(FilePath, json);
        }
        public Dictionary<char, Letra> DesSereliazarLetras()
        {
            string json = File.ReadAllText(filePath);
            Dictionary<Char, Letra> letras = JsonConvert.DeserializeObject<Dictionary<char, Letra>>(json,
            new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            });
            return letras;
        }

    }
}