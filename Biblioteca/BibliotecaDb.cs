using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Models;
using Biblioteca.Models.Documenti;

namespace Biblioteca
{
    /// <summary>
    /// Rappresenta il database della biblioteca.
    /// Contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti.
    /// Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.
    /// </summary>
    public class BibliotecaDb
    {
        readonly List<Documento> documenti = new();
        readonly List<Utente> utenti = new();
        readonly List<Prestito> prestiti = new();

        public void AggiungiDocumento(Documento documento) => documenti.Add(documento);
        public void AggiungiUtente(Utente utente) => utenti.Add(utente);
        public void AggiungiPrestito(Prestito prestito) => prestiti.Add(prestito);

        public Documento? CercaDocumentoPerCodice(string codice) => documenti.FirstOrDefault(documento => documento.Codice == codice);
        public IEnumerable<Documento> CercaDocumentoPerTitolo(string titolo) => documenti.Where(documento => documento.Titolo == titolo);
        
        public IEnumerable<Prestito> CercaPrestito(string nomeUtente, string cognomeUtente) =>
            prestiti.Where(prestito => prestito.Utente.Nome == nomeUtente && prestito.Utente.Congnome == cognomeUtente);
    }
}
