using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiinterclasse.functions
{
    class interclasse
    { public bool verificarpar(decimal numero)
    {
            numero = Math.Ceiling(numero);

            decimal resto = numero% 2;

            if (resto ==0)
            {
                return true;
            }

            else
            {
                return false;
            }

    }

    public double calcformula (double a, double b)
    {
            double s = a / b;
            double r = Math.Pow(s, 4);

            return r;
    }
    public string lucroprejuizo (double gasto,double lucro)
    {
            double saldo = lucro - gasto;

            double absoluto = Math.Abs(saldo);

            string r = "";

            if (saldo>=0)
            {
                r = "O lucro foi de " + absoluto + " reais";

            }
    else
            {
                r = "O prejuizo foi de " + absoluto + " reais";
 }
            return r; 
            }

           public bool possuivogais (string frase)
           {
            frase = frase.ToLower();

            bool a = frase.Contains("a");
            bool e = frase.Contains("e");
            bool i = frase.Contains("i");
            bool o = frase.Contains("o");
            bool u = frase.Contains("u");

            if (a == true && e ==true &&i == true && o == true && u == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
