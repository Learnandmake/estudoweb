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
            string reidade="";
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

        public int calcalorias(int qcomida ,int qbebida , int qsobremesa ,string comida,string bebida, string sobremesa)
        {
           
            int ccomida = 0;
            int cbebida = 0;
            int csobremesa = 0;
           
            
            if(comida == "fast-food")
            {
                ccomida = 300 * qcomida;
             }
            if (comida == "churras")
            { ccomida = 400 * qcomida; }
            if (comida == "lanche-natural")
            { ccomida = 100 * qcomida; }

            if (bebida == "coca-cola")
            { cbebida = 200 * qbebida; }
            if (bebida == "suco-caixa")
            { cbebida = 150 * qbebida; }
            if (bebida == "suco-Natural")
            { cbebida = 80 * qbebida; }

            if (sobremesa== "açai")
            { csobremesa = 350 * qsobremesa; }
            if (sobremesa == "bolo")
            { csobremesa = 270 * qsobremesa; }
            if (sobremesa == "mousse")
            { csobremesa = 300 * qsobremesa; }

            int total = ccomida + cbebida + csobremesa;
            return total;

        }

    }
}
