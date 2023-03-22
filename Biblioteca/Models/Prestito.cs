using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Models.Documenti;

namespace Biblioteca.Models
{
    /// <summary>
    /// Rappresenta il prestito di un documento a un utente.
    /// </summary>
    public class Prestito
    {
        public Prestito(Documento documento, Utente utente)
        {
            Documento = documento;
            Utente = utente;
        }

        public DateTime? DataPrestito { get; set; }
        public DateTime? DataRestituzione { get; set; }
        public Documento Documento { get; set; }
        public Utente Utente { get; set; }
    }
}
