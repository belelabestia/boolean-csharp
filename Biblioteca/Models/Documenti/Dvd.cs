using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models.Documenti
{
    public class Dvd : Documento
    {
        public Dvd(string codice, string titolo) : base(codice, titolo) { }

        public int? DurataInMinuti { get; set; }
    }
}
