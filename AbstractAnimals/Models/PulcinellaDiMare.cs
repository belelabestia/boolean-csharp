using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAnimals.Skills;

namespace AbstractAnimals.Models
{
    public class PulcinellaDiMare : Animale, IVolante, INuotante
    {
        public override void Mangia() => Console.WriteLine("Sassi");
        public override void Verso() => Console.WriteLine("mmmmmm");
    }
}
