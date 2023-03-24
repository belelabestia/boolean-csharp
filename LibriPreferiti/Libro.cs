using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibriPreferiti
{
    public record Libro
    {
        public Libro(string titolo, string autore, int anno)
        {
            Titolo = titolo;
            Autore = autore;
            Anno = anno;
        }

        public string Titolo { get; init; }
        public string Autore { get; init; }
        public int Anno { get; init; }
    }
}
