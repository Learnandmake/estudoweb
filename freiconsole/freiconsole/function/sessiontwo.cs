using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiconsole.function
{
    class sessiontwo
    { public int fmc (int idade)
    {
            int rfmc = 220 - idade;
            return rfmc;
    }

        public decimal imc(decimal peso, decimal altura )
        {
            decimal rimc = peso/(altura * altura);
            return rimc;
        }
    }
}
