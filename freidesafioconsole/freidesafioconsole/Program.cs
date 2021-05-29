using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios;
namespace freidesafioconsole
{
    class Program
    {
        static void Main(string[] args)
        {//SESSIONSIX-DESAFIO
            string cep = "";
            Console.WriteLine("vou consultar seu endereco pelo cep");
            Console.WriteLine("digite seu cep com digito");
            cep = Console.ReadLine();

            Correios.CorreiosApi correios = new CorreiosApi();
            var endereco = correios.consultaCEP(cep);


            Console.WriteLine("Seu endereco é:  "+endereco.cidade+" "+ endereco.end +" "+endereco.bairro +" "+ endereco.complemento);
            Console.ReadKey();


                    }
    }
}
