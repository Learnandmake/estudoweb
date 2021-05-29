using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiconsole.function
{
    class sessionthree
    {
        public bool imparoupa(decimal numero)
        {
            numero = Math.Ceiling(numero);
            bool par = false;
            decimal resto = numero % 2;

            if (resto == 0)
            {
                par = true;

            }

            if (resto == 0)
            {
                par = false;

            }

            return par;
        }

        public decimal arredondartemperatura(decimal numero)
        {
            decimal resultado = Math.Round(numero, 2);

            return resultado;

        }

        public double calcularhipotenusa(double cateto1, double cateto2)
        {
            double cateto3 = Math.Pow(cateto1, 2);
            double cateto4 = Math.Pow(cateto2, 2);

            double somadocateto = cateto3 + cateto4;

            double raiz = Math.Sqrt(somadocateto);

            return raiz;
        }

        public string calbaskhara(double a, double b, double c)
        {
            double delta = ((Math.Pow(b, 2)) - 4 * a * c);

            double xp = ((-b + (Math.Sqrt(delta)) / 2 * a));

            double xn = ((-b + (Math.Sqrt(delta)) / 2 * a));

            string resultado = "O resultado positivo é " + Convert.ToString(xp) + " E o negativo é: " + Convert.ToString(xn) + ".";

            return resultado;
        }


    }
}
}
