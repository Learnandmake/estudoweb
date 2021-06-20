using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessionthree
    {
    public bool vidade (DateTime nascimento)
    {
            bool vidade = false;
            int ano = DateTime.Now.Year - nascimento.Year;

            if(ano>=18 && DateTime.Now.DayOfYear>=nascimento.DayOfYear)
            {
                vidade = true;
                
            }

           else
           {
                vidade = false;
           }
            return vidade;
    }

    }
}
