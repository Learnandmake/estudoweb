using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiconsole.function
{
    class sessionine
    {
        public double calcareatriangulo(double baset, double alturat)
    {
            double resultado = (baset * alturat) / 2;
            return resultado;

    }

        public double calccircunferencia(double raio)
        {
        double pi = 3.14;
        double resultado = (pi * Math.Pow(raio, 2));

            return resultado;
        }

        public double calcperoctogono(double lado)
        {
            double resultado = lado * 8;

            return resultado;

        }

        

        public bool corprimaria (string cor)
        {
            bool resultado = false;
           if(cor =="amarelo"|| cor == "vermelho"||cor ==  "azul")
           {
                resultado = true;

           }

           else
           {
                resultado = false;
           }
            return resultado;
        }

        public string correprimaria (string cor1,string cor2)
        {
            string corresultante = "";
        if(cor1== "vermelho" && cor2 == "azul")
        {
                corresultante = "roxo";
         }
            if (cor1 == "azul" && cor2 == "amarelo")
            {
                corresultante = "verde";
           
            }

            if (cor1 == "vermelho" && cor2 == "amarelho")
            {
                corresultante = "laranja";
                
            }

            return corresultante;
        }

        

    }
}
