using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimals.Models
{
    /*
     - void Dormi() (mostra a video “Zzz”)
    - void Verso() (mostra a video il verso fatto dall'animale specifico)
    - void Mangia() (mostra a video quello che mangia : erba, carne, ...?)
     */
    public abstract class Animale
    {
        public virtual void Dormi() => Console.WriteLine("Zzz");
        public abstract void Verso();
        public abstract void Mangia();
    }
}
