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

        public double calcperoctogono (double lado)
        {
            double resultado = lado * 8;

            return resultado;

        }
    }
}
