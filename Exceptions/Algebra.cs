using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public static class Algebra
    {
        public static double Divide(double n, double d) => n / d;

        public static int MaybeOne()
        {
            RadomFailer.MaybeFail();
            return 1;
        }
    }
}
