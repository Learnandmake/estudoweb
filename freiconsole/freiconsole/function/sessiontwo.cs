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

        public decimal ingresso (decimal valor, int qtdinteira, int qtdmeia)
        {
            decimal vli = valor * qtdinteira;
            decimal vlm = (valor * qtdmeia) / 2;
            decimal resultado = vli + vlm;
            return resultado;

        }
        public string verificaridade(int idade)
        {
            string reidade;
            if (idade >= 18)
            {
                reidade = "sim";
                return reidade;
            }
           
            if (idade < 18)
            {
                reidade = "não";
                return reidade;
            }

            return reidade;

        }

        public string conselho(decimal nota)
        {
            string dica;
        if (0<=3)
        {
                dica = "Verifique os pontos de dificuldade antes de continuar.";
                return dica;
            }
            if (3 <= 5)
            {
                dica = "Trabalhe para entender os conceitos antes de programar.";
                return dica;
            }
            if (5 <= 8)
            {
                dica = "Trabalhe para entender os conceitos antes de programar.";
                return dica;
            }
            if (8 <= 10)
            {
                dica = " Treine com uma intensidade alta para ficar fluente e ágil.";
                return dica;
            }

            return dica;
        }
    }
}
