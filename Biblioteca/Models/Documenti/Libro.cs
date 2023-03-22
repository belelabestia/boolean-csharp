using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models.Documenti
{
    public class Libro : Documento
    {
        public Libro(string codice, string titolo) : base(codice, titolo) { }

        public int? NumeroPagine { get; set; }
    }
}
