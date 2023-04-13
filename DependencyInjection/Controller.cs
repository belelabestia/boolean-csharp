using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Controller
    {
        Context ctx;

        public Controller(Context ctx)
        {
            this.ctx = ctx;
        }

        public void Endpoint(Model model)
        {

            switch (model.Operation)
            {
                case "add":
                    ctx.Add(model.Paylad);
                    return;
                case "remove":
                    ctx.Remove(model.Paylad);
                    return;
                case "clear":
                    ctx.Clear();
                    return;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
