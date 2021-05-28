using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesafioconsole
{
    class Program
    {
        static void Main(string[] args)
        {//SESSIONSIX-DESAFIO
            string cep = "";
            Console.WriteLine("vou consultar seu endereco pelo cep");
            Console.WriteLine("digite seu cep");
            cep = Console.ReadLine();

            Correiosapi correios = new Correiosapi();
           Console.WriteLine("Seu endereco é:  " +correios.Buscar(cep));


                    }
    }
}
