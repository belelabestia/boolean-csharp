using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibriPreferiti
{
    public static class Parser
    {
        public const string InputFile = "..\\..\\..\\input.txt";
        public const string OutputFile = "..\\..\\..\\output.txt";

        public static IEnumerable<Libro> Read()
        {
            using var input = File.OpenText(InputFile);
            var libri = new List<Libro>();

            input.ReadLine();

            while (true)
            {
                string? line = input.ReadLine();
                if (line is null) return libri;

                var chunks = line.Split(',')!;
                //var titolo = chunks[0].Replace("- ", "");
                var titolo = chunks[0][2..]; // [2..] -> skip primi 2 caratteri, prendi tutto il resto
                var autore = chunks[1];
                var anno = Convert.ToInt32(chunks[2]);

                var libro = new Libro(titolo, autore, anno);
                libri.Add(libro);
            }

        }

        public static void Write(IEnumerable<Libro> libri)
        {
            using var output = File.CreateText(OutputFile);
            output.WriteLine("Lista di Libri Preferiti:");

            foreach (var libro in libri)
            {
                output.WriteLine();
                output.WriteLine("------ Libro ------");
                output.WriteLine($"Titolo: {libro.Titolo}");
                output.WriteLine($"Autore: {libro.Autore}");
                output.WriteLine($"Anno:   {libro.Anno}");
                output.WriteLine("-------------------");
            }
        }
    }
}
