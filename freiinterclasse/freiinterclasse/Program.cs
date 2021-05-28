using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiinterclasse
{
    class Program
    {
        static void Main(string[] args)
        {

            //interclasse

            functions.interclasse interclassefunction = new functions.interclasse();
            //1.exercicio
            Console.WriteLine("Informe um numero");
            decimal n = Convert.ToInt32(Console.ReadLine());

            bool par = interclassefunction.verificarpar(n);

            if(par == true)
            {
                Console.WriteLine("par");
            }

            else 
            {
                Console.WriteLine("ímpar");
            }

            //2.excercicio
            Console.WriteLine("Informe o valor de A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor de B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double r = interclassefunction.calcformula(a, b);

            Console.WriteLine(r); 

            //3.excercicio
            Console.WriteLine("Informe os gastos");
            double gastos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe os lucros");
            double lucros = Convert.ToDouble(Console.ReadLine());

            string r1 = interclassefunction.lucroprejuizo(gastos, lucros);
                        
            Console.WriteLine(r1);

            //4.excercicio
            Console.WriteLine("Informe uma frase:");
            string frase = Console.ReadLine();

            bool r2 = interclassefunction.possuivogais(frase);

            if(r2== true)
            {
                Console.WriteLine("possui todas as vogais");
            }
            
            else
            {
                Console.WriteLine("Não possui todas as vogais");

            }
            
            } 

    }
}
