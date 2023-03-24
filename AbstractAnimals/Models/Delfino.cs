using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAnimals.Skills;

namespace AbstractAnimals.Models
{
    public class Delfino : Animale, INuotante
    {
        public override void Mangia() => Console.WriteLine("Pesce");
        public override void Verso() => Console.WriteLine("E-e-e-i-i-i-i-i-i!");
        public void Nuota() => Console.WriteLine("Sto nuotando");
    }
}
