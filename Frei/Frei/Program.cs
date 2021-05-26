using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei
{
    class Program
    {
        static void Main(string[] args)
        {//1a
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
        }
    }
}
