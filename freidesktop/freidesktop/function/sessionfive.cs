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

            if (frase.Contains(" contra ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" de ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" desde ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" em ") == true)
            {
                total += 1;
            }

            if (frase.Contains(" entre ") == true)
            {
                total += 1;
            }

            if (frase.Contains(" para ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" per ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" perante ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" por ") == true)
            {
                total += 1;
            }

            if (frase.Contains(" sem ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" sob ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" sobre ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" trás ") == true)
            {
                total += 1;
            }

            if (frase.Contains(" afora ") == true)
            {
                total += 1;
            }

            if (frase.Contains(" como ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" conforme ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" durante ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" exceto ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" mediante ") == true)
            {
                total += 1;
            }

            if (frase.Contains(" menos ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" salvo ") == true)
            {
                total += 1;
            }
            if (frase.Contains(" segundo ") == true)
            {
                total += 1;
            }

            if (frase.Contains(" visto ") == true)
            {
                total += 1;
            }

            return total;
        }
    }


}
