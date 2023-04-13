using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Context
    {
        List<int> collection = new();

        public virtual void Add(int n) => collection.Add(n);
        public virtual void Clear() => collection.Clear();
        public virtual void Remove(int n) => collection.Remove(n);
        public virtual int Count => collection.Count;
    }

    public class AAA : Context
    {

    }
}
