using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimals.Skills
{
    public interface IVolante
    {
        void Vola() => Console.WriteLine("STO VOLANDO"); // this is weird behavior
    }
}
