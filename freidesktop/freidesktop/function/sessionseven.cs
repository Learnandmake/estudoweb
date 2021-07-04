using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessionseven
    {
    public decimal total (decimal qtdacai300ml,decimal qtdacai500ml,decimal qtdacompanhamento,decimal qtdpastel, decimal qtdpastelespecial,decimal qtdpasteldoce)
        {
            decimal acai300ml = qtdacai300ml*12;
            decimal acai500ml = qtdacai500ml * 15;
            decimal acompanhamento = qtdacompanhamento*2;
            decimal pastelnormal =qtdpastel* 4;
            decimal pastelespecial = qtdpastelespecial * 8;
            decimal pasteldoce = qtdpasteldoce * 6;
            decimal total = 0;
          
            if (qtdacai300ml > 5)
            {
                decimal porcentagem = (acai300ml/100)*10;
                acai300ml = acai300ml - porcentagem;
            }
            if (qtdacai500ml > 5)
            {
                decimal porcentagem = (acai500ml / 100) * 10;
                acai500ml = acai500ml - porcentagem;
            }
            if (qtdacompanhamento > 5)
            {
                decimal porcentagem = (acompanhamento / 100) * 10;
                acompanhamento = acompanhamento - porcentagem;
            }
            if (qtdpastel > 5)
            {
                decimal porcentagem = (pastelnormal / 100) * 10;
                pastelnormal = pastelnormal - porcentagem;
            }
            if (qtdpastelespecial > 5)
            {
                decimal porcentagem = (pastelespecial / 100) * 10;
                pastelespecial = pastelespecial - porcentagem;
            }
            if (qtdpasteldoce > 5)
            {
                decimal porcentagem = (pasteldoce / 100) * 10;
                pasteldoce = pasteldoce - porcentagem;
            }
            total = acai300ml + acai500ml + acompanhamento + pastelnormal + pastelespecial + pasteldoce;
        


            return total;
    }
    }
}
