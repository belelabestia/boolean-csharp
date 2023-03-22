using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    /// <summary>
    /// Rappresenta l'utente della biblioteca.
    /// </summary>
    public class Utente
    {
        public Utente(string nome, string cognome)
        {
            Nome = nome;
            Congnome = cognome;
        }

        public string Nome { get; set; }
        public string Congnome { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RecapitoTelefonico { get; set; }
    }
}
