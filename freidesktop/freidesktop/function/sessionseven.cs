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
            decimal acai300ml = 0;
            decimal acai500ml = 0;
            decimal acompanhamento = 0;
            decimal pastelnormal = 0;
            decimal pastelespecial = 0;
            decimal pasteldoce = 0;
            decimal total = 0;
          
            //normal
            if (qtdacai300ml > 5)
            {
                decimal porcentagem = ((qtdacai300ml * 12)/100)*10;
                acai500ml = qtdacai300ml - porcentagem;
            }
            if(acai500ml > 5)
            {
                decimal porcentagem = ((qtdacai500ml * 15) / 100) * 10;
                acai500ml = qtdacai500ml - porcentagem;
            }   
            if(acompanhamento > 5)
            {
                decimal porcentagem = ((acompanhamento * 2) / 100) * 10;
                acompanhamento = acompanhamento - porcentagem;
            }
            
            if(qtdpastel > 5)
            {
                decimal porcentagem = ((qtdpastel * 4) / 100) * 10;
                qtdpastel = qtdpastel - porcentagem;
            }

            if(qtdpastelespecial > 5)
            {
                decimal porcentagem = ((qtdpastelespecial * 8) / 100) * 10;
                qtdpastelespecial = qtdpastelespecial - porcentagem;
            }
            if (qtdpasteldoce > 5)
            {
                decimal porcentagem = ((qtdpasteldoce * 6) / 100) * 10;
                qtdpasteldoce = qtdpasteldoce - porcentagem;
            }
         else
         {
                acai300ml = qtdacai300ml * 12;
                acai500ml = qtdacai500ml * 15;
                acompanhamento = qtdacompanhamento * 2;
                pastelnormal = qtdpastel * 4;
                pastelespecial = qtdpastelespecial * 8;
                pasteldoce = qtdpasteldoce * 6;

         }
           //comdesconto
           total = acai300ml + acai500ml + acompanhamento + pastelnormal + pastelespecial + pasteldoce;
        


            return total;
    }
    }
}
