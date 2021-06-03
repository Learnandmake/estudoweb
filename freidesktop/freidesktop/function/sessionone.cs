using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessionone
    {
        public int calcfmc(int idade)
        {
            int resultado = 220 - idade;
            return resultado;
        }
        public double calcimc(double peso, double altura)
        {
            double resultado = (peso / (Math.Pow(altura, 2)));
            Math.Round(resultado, 2);
            return resultado;
        }

        public bool vmidade(int idade)
        {
            bool re = false;

            if(idade>=18)
            {
                re = true;
            }
            else
            {
                re = false;
            }
            return re;
        }


    }
}
