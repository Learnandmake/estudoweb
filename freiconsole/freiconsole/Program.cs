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
            Console.WriteLine("Vamos calcular uma soma");
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
            Console.WriteLine("Vamos calcular sua média ");
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
            decimal valor = 0;
            decimal total = 0;

            Console.WriteLine("Informe a quantidade de ingressos");
            quantidade = 0;
            Console.WriteLine("Informe o valor do ingresso");
            valor = 0;
            total = quantidade * valor;
            Console.WriteLine("P total a pagar é " + total);

            //3a
            int n3 = 0;
            int n4 = 0;
            int soma2 = 0;
            Console.WriteLine("Vamos calcular uma soma de novo");
            Console.WriteLine("Informe o primeiro número:");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            n4 = Convert.ToInt32(Console.ReadLine());
            function.sessionone calculadora = new function.sessionone();
            soma2 = calculadora.somar(n3, n4);
            Console.WriteLine("A soma é: " + soma2);

            //3b
            decimal nota4 = 0;
            decimal nota5 = 0;
            decimal nota6 = 0;
            decimal media2 = 0;
            Console.WriteLine("Vamos calcular sua média de novo");
            Console.WriteLine("informe a primeira nota");
            nota4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("informe a segunda nota");
            nota5 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("informe a terceira nota");
            nota6 = Convert.ToDecimal(Console.ReadLine());
            function.sessionone calculadora2 = new function.sessionone();
            media2 = calculadora2.media(nota4, nota5, nota6);

            //SESSIONTWO

            //NIVEL1
            //a
            int idade1 = 0;
            int fmc = 0;
            Console.WriteLine("Hoje irei calcular sua frequência média cardíaca");
            Console.WriteLine("Informe sua idade");
            idade1 = Convert.ToInt32(Console.ReadLine());

            function.sessiontwo fmc1 = new function.sessiontwo();
            fmc = fmc1.fmc(idade1);

            Console.WriteLine("Sua frequência média cardíaca é " + fmc);

            //b
            decimal altura = 0;
            decimal peso = 0;
            decimal imc = 0;
            Console.WriteLine("Vamos calcular seu imc");
            Console.WriteLine("Informe sua altura");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe seu peso");
            peso = Convert.ToDecimal(Console.ReadLine());
            function.sessiontwo fimc = new function.sessiontwo();
            imc = fimc.imc(peso, altura);
            Console.WriteLine("Seu imc é " + imc);

            //c
            decimal valor1 = 0;
            int qtdinteira = 0;
            int qtdmeia = 0;
            decimal total1 = 0;
            Console.WriteLine("Vamos calcular tipos de  ingressos inteiros  e meios");

            Console.WriteLine("qual o valor do ingresso?");
            valor1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("quantas inteiras?");
            qtdinteira = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quantas meias?");
            qtdmeia = Convert.ToInt32(Console.ReadLine());
            function.sessiontwo ingresso = new function.sessiontwo();
            total1 = ingresso.ingresso(valor, qtdinteira, qtdmeia);
            Console.WriteLine("O total é " + total1);

            //NIVEL2
            //a
            int idade2 = 0;
            string re;
            Console.WriteLine("Vou verificar sua maioridade");
            Console.WriteLine("Informe sua idade");
            idade2 = Convert.ToInt32(Console.ReadLine());
            function.sessiontwo vidade = new function.sessiontwo();
            re = vidade.verificaridade(idade2);
            Console.WriteLine("É maior de idade? " + re);

            //b
            decimal nota7 = 0;
            Console.WriteLine("Vou te aconselhar a estudar");
            Console.WriteLine("Me fale sua nota");
            nota7 = Convert.ToDecimal(Console.ReadLine());
            function.sessiontwo dica = new function.sessiontwo();
            string conselho = dica.conselho(nota7);

            Console.WriteLine("Eu te aconselho a " + conselho);

            //c
            string comida = "";
            string bebida = "";
            string sobremesa = "";
            int qcomida = 0;
            int qbebida = 0;
            int qsobremesa = 0;
            int caloria = 0;

            Console.WriteLine("Vamos medir suas calorias");
            Console.WriteLine("O que voce comeu?");
            Console.WriteLine("Comida:fast-food/churras/lanche-natural");
            comida = Console.ReadLine();
            Console.WriteLine("quantidade?");
            qcomida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O que vc bebel?");
            Console.WriteLine("Bebida:coca-cola/suco-caixa/suco-Natural");
            bebida = Console.ReadLine();
            Console.WriteLine("quantidade?");
            qbebida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual foi sua sobremesa?");
            Console.WriteLine("Sobremesa:açai/bolo/mousse");
            sobremesa = Console.ReadLine();
            Console.WriteLine("quantidade?");
            qsobremesa = Convert.ToInt32(Console.ReadLine());

            function.sessiontwo calkcal = new function.sessiontwo();
            caloria = calkcal.calcalorias(qcomida, qbebida, qsobremesa, comida, bebida, sobremesa);

            Console.WriteLine("voce ingeriu no total" + caloria + "kcal");

            //NIVEL3

            //a
            Console.WriteLine("vamos ver o periodo historico");
            function.sessiontwo contar = new function.sessiontwo();

            string periodo1;
            int chistoria = -4000;

            while (chistoria < 2019)
            {
                chistoria++;
                Console.WriteLine(chistoria);
            }

            while (chistoria < 2019)
            {
                function.sessiontwo st = new function.sessiontwo();
                periodo1 = st.contarhistorico(chistoria);
                Console.WriteLine(periodo1);
            }

            //b
            Console.WriteLine("Vou calcular a tabuada até cem apartir de um numero que você dé");
            int numero = 0;
            int total2 = 0;
            function.sessiontwo tabuada = new function.sessiontwo();
            total2 = tabuada.tabuadaate100(numero);

            Console.WriteLine(total2);

            //c
            Console.WriteLine("Vou calcular a tabuada do 2 até o limite indicado");
            Console.WriteLine("Digite o limite indicado");
            int limite = Convert.ToInt32(Console.ReadLine());
            function.sessiontwo atenumero = new function.sessiontwo();
            int tabuada1 = 0;


            while (tabuada1 <= limite)
            {
                tabuada1 = atenumero.tabuada2atelimite(limite);
                Console.WriteLine(tabuada1);
            }

            //SESSIONTHREE
            //1
            Console.WriteLine("Vou ver se seu numero é impar ou par");
            Console.WriteLine("digite um numero inteiro");
            decimal n5 = Convert.ToDecimal(Console.ReadLine());
            function.sessiontwo imparoupar = new function.sessiontwo();
            bool resultado = imparoupar.imparoupa(n5);

            if (resultado == true)
            { Console.WriteLine("Seu número é par"); }

            if (resultado == false)
            { Console.WriteLine("Seu número é impar"); }

            //2
            Console.WriteLine("vou arredondar sua temperatura");
            decimal n6 = 0;
            Console.WriteLine("Informe a temperatura");
            

        }



    }
}
