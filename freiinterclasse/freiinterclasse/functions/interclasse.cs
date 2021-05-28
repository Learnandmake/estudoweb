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

            public double calcularraiz(double numero)
            {
            double raiz = Math.Sqrt(numero);
            return raiz;

            }

        public double arredondar(double numero)
        {
            double abs = Math.Abs(numero);
            double dec = numero - abs;

            if (dec >= 0 && dec <= 0.34)
            {
                numero = Math.Floor(numero);

            }

            if( dec >= 0.35 && dec <= 0.74)
            {
                numero = abs + 0.5;

            }

            if( dec >= 0.75)
            {
                numero = Math.Ceiling(numero);
            }
            return numero;
            }

            public string empresaemail(string email)
            {
            int arroba = email.IndexOf("@");
            int ponto = email.IndexOf(".", arroba);

            int inicio = arroba + 1;
            int tamanho = ponto - inicio;

            string empresa = email.Substring(inicio, tamanho);

            return empresa;

            }

            public string inverter (string palavra)
            {
            int hifen = palavra.IndexOf("-");
            string primeira = palavra.Substring(0, hifen);
            string ultima = palavra.Substring(hifen + 1);

            string invertida = ultima + "-" + primeira;

            return invertida;
            }

        public string formatar(string palavra)
        {
            string convertida = "";
            bool iniciopalavra = false;

            for (int i = 0; i < palavra.Length; i++)
            {
                string letra = palavra.Substring(i, 1);

                if (i == 0 || iniciopalavra == true)
                    convertida = convertida + letra.ToLower();

                else
                    convertida = convertida + letra.ToUpper();

                if (letra == " ")
                    iniciopalavra = true;
                else
                    iniciopalavra = false;
            }
            return convertida;

            }

            public string aocontrario (string palavra)
            {
            string convertida = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                string letra = palavra.Substring(i, 1);

                convertida = letra + convertida;

            }
            return convertida;
            }

    }
}
