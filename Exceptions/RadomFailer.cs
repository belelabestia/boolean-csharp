using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class RadomFailer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="RandomException"></exception>
        public static void MaybeFail()
        {
            var r = new Random();
            var n = r.Next(0, 100);

            if (n < 50) throw new RandomException();
        }
    }

    public class RandomException : Exception
    {
        public RandomException() : base("This operation could succeed, but it didn't (eheh)") { }
    }
}
