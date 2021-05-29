using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiintensivoconsole.function
{
    class intensivo
    {
    public double calcularmedia (double n1, double n2,double n3, double n4)
    {
            double media = (n1 + n2 + n3 + n4) / 4;
            return media;

    }

    public string darsugestao(double media)
    {
            string sugestao = "";
            if(media >= 0 && media <= 3)
            {
                sugestao = "Verifique os pontos de dificuldade antes de continuar";

            }

            else if (media >3 && media <=5)
            { sugestao = "trabalhe para entender os conceitos antes de programar"; }

            else if (media > 5 && media <= 8)
            { sugestao = "treine com uma intendidade alta para ficar fluente"; }

            else  
            { sugestao = "busque treinos que bugam seu cerebro e desafie sua mente"; }

            return sugestao;
        }

        public double somar( double n1, double n2)
        {
            double r = n1 + n2;
            return r;

        }

        public double subtrair(double n1, double n2)
        {
            double r = n1 + n2;
            return r;

        }

        public double multiplicar(double n1, double n2)
        {
            double r = n1 * n2;
            return r;

        }

        public double dividir(double n1, double n2)
        {
            double r = n1 / n2;
            return r;

        }

        public double potencia(double n, double potencia)
        {
            double r = Math.Pow(n,potencia);
            return r;

        }

        public double raizquadrada(double n)
        {
            double r = Math.Sqrt(n);
            return r;

        }

        public bool corprimaria (string cor)
        {
            cor = cor.ToLower();

            if(cor == "azul" || cor == "amarelo"|| cor == "vermelho")
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
