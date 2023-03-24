using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAnimals.Skills;

namespace AbstractAnimals.Models
{
    public class Passerotto : Animale, IVolante
    {
        public override void Mangia() => Console.WriteLine("Vermi, semi");
        public override void Verso() => Console.WriteLine("Cip cip");
        public void Vola() => Console.WriteLine("Sto volando");
    }
}
