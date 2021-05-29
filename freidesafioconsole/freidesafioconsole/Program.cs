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
        {   //DESAFIO-EMAIL

            string remetente = "testinmail21@gmail.com";
            string senha = "98847685";

            string destinatario = "";
            string assunto = "";
            string mensagem="";



            Console.WriteLine("digite o destinatario");
            destinatario = Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite o assunto");
            assunto = Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite a mensagem");
            mensagem = Convert.ToString(Console.ReadLine());

            gmailsender gmail = new gmailsender();

            gmail.ConfigurarCredenciais(remetente, senha);

            gmail.Enviar(destinatario, assunto, mensagem);
            Console.WriteLine("email enviado");



            //SESSIONSIX-DESAFIO CEP
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
