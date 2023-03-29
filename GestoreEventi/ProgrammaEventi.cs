using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        private string titolo;
        private List<Evento> eventi = new();

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> EventiInData(DateTime data)
        {
            var res = new List<Evento>();

            foreach (Evento evento in eventi)
            {
                if (evento.Data == data)
                {
                    res.Add(evento);
                }
            }

            return res;
        }

        public static string StampaEventi(List<Evento> eventi)
        {
            var line = Environment.NewLine;
            string res = string.Empty;

            foreach (Evento evento in eventi)
            {
                res += evento.ToString() + line;
            }

            return res;
        }

        public int NumeroEventi()
        {
            return eventi.Count;
        }

        public void SvuotaEventi()
        {
            eventi.Clear();
        }

        public override string ToString()
        {
            var line = Environment.NewLine;
            return titolo + line + StampaEventi(eventi);
        }
    }
}
