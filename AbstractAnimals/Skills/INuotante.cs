using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimals.Skills
{
    public interface INuotante
    {
        void Nuota() => Console.WriteLine("STO NUOTANDO"); // this is weird behavior
    }
}
