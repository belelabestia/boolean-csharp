using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models.Documenti
{
    public class Documento
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int? Anno { get; set; }
        public string? Settore { get; set; }
        public string? Scaffale { get; set; }
        public string? NomeAutore { get; set; }
        public string? CognomeAutore { get; set; }

        public Documento(string codice, string titolo)
        {
            Codice = codice;
            Titolo = titolo;
        }
    }
}
