using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freiconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //SESSIONONE
            //1a
            Console.WriteLine("Hello world");

            //1b
            string nome = "";
            Console.WriteLine("Bem-vindo, qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Seja bem-vindo " + nome);

            //1c
            string nome2 = "";
            string idade = "";
            Console.WriteLine("qual seu nome?");
            nome2 = Console.ReadLine();

            Console.WriteLine("qual a sua idade?");
            idade = Console.ReadLine();
            Console.WriteLine("Olá " + nome2 + " , a idade de " + idade + " é a melhor!");

            //2a
            int n1 = 0;
            int n2 = 0;
            int soma = 0;
            Console.WriteLine("Informe o primeiro número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            n2 = Convert.ToInt32(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("A soma é " + soma);

            //2b
            decimal nota1 = 0;
            decimal nota2 = 0;
            decimal nota3 = 0;

            Console.WriteLine("informe a primeira nota");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("informe a segunda nota");
            nota2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("informe a terceira nota");
            nota3 = Convert.ToDecimal(Console.ReadLine());

            decimal media = nota1 + nota2 + nota3 / 3;

            Console.WriteLine("Sua média é " + media);

            //2c
            int quantidade = 0;
            decimal valor =  0;
            decimal total = 0;

            Console.WriteLine("Informe a quantidade de ingressos");
             quantidade = 0;
            Console.WriteLine("Informe o valor do ingresso");
            valor = 0;
            total = quantidade * valor;
            Console.WriteLine("P total a pagar é "+total);

            //3a
            int n3 = 0;
            int n4 = 0;
            int soma2 = 0;
            Console.WriteLine("Informe o primeiro número:");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            n4 = Convert.ToInt32(Console.ReadLine());
            function.sessionone calculadora = new function.sessionone();
            soma2= calculadora.somar(n3, n4);
            Console.WriteLine("A soma é: " + soma2);

            //3b
            decimal nota4 = 0;
            decimal nota5 = 0;
            decimal nota6 = 0;
            decimal media2 = 0;
            Console.WriteLine("informe a primeira nota");
            nota4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("informe a segunda nota");
            nota5 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("informe a terceira nota");
            nota6 = Convert.ToDecimal(Console.ReadLine());
            function.sessionone calculadora2 = new function.sessionone();
            media2 = calculadora2.media(nota4, nota5, nota6);

            //SESSIONTWO
            
            //nivel1

        }
    }
}
