using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiintensivoconsole
{
    class Program
    {
        static void Main(string[] args)
        { //1.exercicio
            Console.WriteLine("informe a nota 1:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota 2:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota 3:");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota 4:");
            double n4 = Convert.ToDouble(Console.ReadLine());

            function.intensivo intensivo = new function.intensivo();
            double media = intensivo.calcularmedia(n1, n2, n3, n4);
            string sugestao = intensivo.darsugestao(media);

            Console.WriteLine("Sua media é: " + media);
            Console.WriteLine(sugestao);

            //2.exercicio


        }
    }
}
