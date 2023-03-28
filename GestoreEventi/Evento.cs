using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMax;
        private int postiPrenotati;

        public Evento(string titolo, DateTime data, int capienzaMax) 
        {
            Titolo = titolo;
            Data = data;
            CapienzaMax = capienzaMax;
        }

        public string Titolo
        {
            get { return titolo; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be left empty.");
                }

                titolo = value;
            }
        }

        public DateTime Data
        {
            get { return data; }
            private set 
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Date must be in the future.");
                }

                data = value; 
            }
        }

        public int CapienzaMax
        {
            get { return capienzaMax; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capienza must be a positive integer.");
                }

                capienzaMax = value;
            }
        }

        public int PostiPrenotati
        {
            get { return postiPrenotati; }
            private set { postiPrenotati = value; }
        }

        private int PostiDisponibili
        {
            get { return CapienzaMax - PostiPrenotati; }
        }

        public void PrenotaPosti(int posti)
        {
            EnsureDateIsNotPast();

            if (CapienzaMax is 0)
            {
                throw new InvalidOperationException("This event is for 0 people, cannot book.");
            }

            if (PostiDisponibili < posti)
            {
                throw new InvalidOperationException("Not enough seats available.");
            }

            PostiPrenotati += posti;
        }

        public void DisdiciPosti(int posti)
        {
            EnsureDateIsNotPast();

            if (PostiPrenotati < posti)
            {
                throw new InvalidOperationException("Not enought bookings to undo.");
            }

            PostiPrenotati -= posti;
        }

        public override string ToString()
        {
            return $"{Data.ToString("dd/MM/yyyy")} - {Titolo}";
        }

        private void EnsureDateIsNotPast()
        {
            if (Data < DateTime.Now)
            {
                throw new InvalidOperationException("Cannot book, event is passed.");
            }
        }
    }
}
