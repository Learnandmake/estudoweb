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
            //5.exercicio
            Console.WriteLine("Informe um numero:");
            string n1 = Console.ReadLine();

            double numero = Convert.ToDouble(n1.Trim());

            double r3 = interclassefunction.calcularraiz(numero);

            Console.WriteLine(r3);

            //6.exercicio
            Console.WriteLine("Informe um numero");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double r4 = interclassefunction.arredondar(n2);

            Console.WriteLine(r4);

            //7.exercicio
            Console.WriteLine("informe um e-mail");
            string email = Console.ReadLine();

            string r5 = interclassefunction.empresaemail(email);

            Console.WriteLine(r5);

            //8.exercicio
            Console.WriteLine("informe uma palavra composta");
            string palavra = Console.ReadLine();

            string r6 = interclassefunction.inverter(palavra);

            Console.WriteLine(r6);


            //9.exercicio
            Console.WriteLine("informe uma palavra composta:");

            string r7 = interclassefunction.formatar(palavra);

            Console.WriteLine(r7);

            //10.exercicio
            Console.WriteLine("Informe uma palavra composta:");
            string palavra1 = Console.ReadLine();
            string r8 = interclassefunction.aocontrario(palavra1);

            Console.WriteLine(r8);

            //11.exercicio
            Console.WriteLine("Informe um RG:");
            string palavra2 = Console.ReadLine();

            bool r9 = interclassefunction.ganhou(palavra2);

            if( r9 == true)
            {
                Console.WriteLine("Ganhou");

            }

            else
            {
                Console.WriteLine("Perdeu");
            }

            Console.WriteLine("Informe um CPF:");
            string palavra3 = Console.ReadLine();

            string r10 = interclassefunction.formatarcpf(palavra3);

            Console.WriteLine(r10);

            Console.WriteLine("Informe um frase:");
            string frase2 = Console.ReadLine();

            string r11 = interclassefunction.zenitpolar(frase2);

            Console.WriteLine(r11);

            Console.WriteLine(" informe um Cpf:");
            string palavra4 = Console.ReadLine();

            string ag = interclassefunction.leragencia(palavra3);
            string cc = interclassefunction.lerconta(palavra3);

            Console.WriteLine(ag);
            Console.WriteLine(cc);
       

             }



    }
}
