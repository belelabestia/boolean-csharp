using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAnimals.Skills;

namespace AbstractAnimals.Models
{
    public class Aquila : Animale, IVolante
    {
        public override void Mangia() => Console.WriteLine("Carne");
        public override void Verso() => Console.WriteLine("IIIIEE!");
        public void Vola() => Console.WriteLine("Sto volando");
    }
}
