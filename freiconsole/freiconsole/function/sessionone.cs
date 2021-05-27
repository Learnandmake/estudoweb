using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiconsole.function
{
    class sessionone
    { public int somar(int n1, int n2)
    {
            int soma = n1 + n2;
            return soma;

    }
    public decimal media (decimal n1,decimal n2, decimal n3)
    {
            decimal media = (n1 + n2 + n3) / 3;
            return media;
    }
    public decimal calculartotal(int quantidade,decimal valor)
    {
            decimal total = quantidade * valor;
            return total;

    }
    public decimal calculartotal (int qtd,decimal vl,string tipo)
{
            decimal total = 0;
            
            if(tipo =="inteira")
            {

                total = qtd * vl;
            }

            else
            {

                total = (qtd * vl) / 2;
            }

            return total;
}

public decimal calmedia (decimal nt1,decimal nt2,decimal nt3)
{
            decimal media = (nt1+ nt2+ nt3)/ 3;
            return media;

}

public void verificarmedia (decimal media)
{
if(media >= 5)
{
                Console.WriteLine("Parabéns, você passou!");

}

else
            {
                Console.WriteLine("Infelizmento, você não passou");

            }

        }
    }
}
