using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessionfive
    {
    public decimal calcarea (decimal  b, decimal a)
    {
            decimal ar = b * a;
            return ar;
    }
        public decimal calcper(decimal b, decimal a)
        {
            decimal per = b + a;
            return per;
        }

        public int qtdai(string frase)
        {
           
            int total = 0;
            if (frase.Contains(" um ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" uma ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" uns ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" umas ") == true)
            {
                total += 1;
            }

            return total;
    }

        public int qtdar(string frase)
        {
         
            int total = 0;
            if (frase.Contains(" a ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" o ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" as ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" os ") == true)
            {
                total += 1;
            }

            return total;
        }

        public int qtdpre(string frase)
        {

            int total = 0;
            if (frase.Contains(" a ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" ante ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" após ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" até ") == true)
            {
                total += 1;
            }

            if (frase.Contains(" com ") == true)
            {
                total += 1;
            }

            return total;
        }
    }


}
