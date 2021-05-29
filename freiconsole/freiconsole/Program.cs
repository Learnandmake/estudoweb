using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            //3c
            int quantidadeingresso = 0;
            decimal valoringresso = 0;
            decimal totalingresso = 0;

            Console.WriteLine("Informe a quantidade de ingressos");
            quantidadeingresso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de ingressos");
            valoringresso = Convert.ToInt32(Console.ReadLine());

            function.sessionone bilhete = new function.sessionone();
            totalingresso = bilhete.calculartotal(quantidade, valoringresso);

            //4a
            decimal nota4a = 0;
            decimal nota4a1 = 0;
            decimal nota4a2 = 0;
            decimal media4a = 0;

            Console.WriteLine("Informe a primeira nota");
            nota4a = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Informe a segunda nota");
            nota4a1 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Informe a terceira nota");
            nota4a2 = Convert.ToDecimal(Console.ReadLine());

            media4a = (nota4a + nota4a1 + nota4a2) / 3;

            Console.WriteLine("A média é: " + media4a);

            if (media4a >= 5)
            {
                Console.WriteLine("Parabéns, você passou!");

            }

            else
            {
                Console.WriteLine("Infelizmente você não passou");
            }

            //4b
            int quantidadeingresso1 = 0;
            decimal valoringresso1 = 0;
            string tipoingresso = "";
            decimal totalingresso1 = 0;

            Console.WriteLine("Informe a quantidade de ingressos");
            quantidadeingresso1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor dos ingressos");
            valoringresso1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tipo de ingresso");
            tipoingresso = Console.ReadLine();

            if(tipoingresso == "inteira")
            {
                totalingresso1 = quantidadeingresso1 * valoringresso1;

            }

            else 
            {
                totalingresso1 = (quantidadeingresso1 * valoringresso1)/2 ;
            }

            Console.WriteLine("O total a pagar é: " +totalingresso1);

            //4c
            int qtdingresso2 = 0;
            decimal vlingresso2 = 0;
            string tipoing = "";
            decimal tlingresso = 0;

            Console.WriteLine("Informe a quantidade de ingressos");
            qtdingresso2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor dos ingressos");
            vlingresso2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tipo de ingresso");
            tipoing = Console.ReadLine();

            function.sessionone calc = new function.sessionone();

            tlingresso = calc.calculartotal(qtdingresso2, vlingresso2, tipoing);

            Console.WriteLine("O total a pagar é: " + total);

            //4d
            decimal nt1 = 0;
            decimal nt2 = 0;
            decimal nt3 = 0;
            decimal ma = 0;

            Console.WriteLine("informe a primeira nota ");
            nt1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe a segunda nota ");
            nt2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe a terceira nota ");
            nt3 = Convert.ToDecimal(Console.ReadLine());

            function.sessionone calmedia = new function.sessionone();
            ma = calmedia.calmedia(nt1, nt2, nt3);

            Console.WriteLine("A média é: " + ma);

            calmedia.verificarmedia(media);
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
            int ano = -4000;
            int ano1 =  contar.contarhist(ano);
          
            contar.showhist(ano1);
           

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
                atenumero.tabuadaate100(numero);
            }

            //SESSIONTHREE
            //1
            Console.WriteLine("Vou ver se seu numero é impar ou par");
            Console.WriteLine("digite um numero inteiro");
            decimal n5 = Convert.ToDecimal(Console.ReadLine());
            function.sessionthree imparoupar = new function.sessionthree();
            bool resultado = imparoupar.imparoupa(n5);

            if (resultado == true)
            { Console.WriteLine("Seu número é par"); }

            if (resultado == false)
            { Console.WriteLine("Seu número é impar"); }

            //2
            Console.WriteLine("vou arredondar sua temperatura");
            decimal n6 = 0;
            decimal n7 = 0;
            Console.WriteLine("Informe a temperatura");
            n6 = Convert.ToDecimal(Console.ReadLine());
            function.sessionthree arredondar = new function.sessionthree();
            n7 = arredondar.arredondartemperatura(n6);
            Console.WriteLine("Sua temperatura arredondade é " + n7 + "°C");

            //3
            double cat1;
            double cat2;
            double hip;
            Console.WriteLine("Vou calcular uma hipotenusa");


            Console.WriteLine("Digite o valor do primeiro cateto");
            cat1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do primeiro cateto");
            cat2 = Convert.ToDouble(Console.ReadLine());

            function.sessionthree hipfun = new function.sessionthree();
            hip = hipfun.calcularhipotenusa(cat1, cat2);
            Console.WriteLine("A hipotenusa é " + hip);

            //4
            Console.WriteLine("Vou calcular baskhara");
            double a = 0;
            double b = 0;
            double c = 0;

            Console.WriteLine("Digite o valor do a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do b ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do c");
            c = Convert.ToDouble(Console.ReadLine());

            function.sessionthree bhasfunction = new function.sessionthree();
            string resultado3 = bhasfunction.calbaskhara(a, b, c);
            Console.WriteLine(resultado3);

            //5
            Console.WriteLine("Vou colocar sua frase em maiucula e depois em minuscula");
            string frase = "";

            frase = Console.ReadLine();
            Console.WriteLine("Sua frase em maiuscula fica" + frase.ToUpper());

            Console.WriteLine("Sua frase em minuscula fica" + frase.ToLower());

            //6
            Console.WriteLine("Vou falar quantas letras tem sua palavra");
            Console.WriteLine("Infome a palavra");
            string palavra = Console.ReadLine();
            int legth = palavra.Length;
            Console.WriteLine("Sua palavra tem " + legth + " letras");

            //7
            Console.WriteLine("Vou dizer a primeira e a ultima letra da sua palavra");
            Console.WriteLine("Digite a palavra");
            string palavra1 = Console.ReadLine();
            string pletra = palavra1.Substring(1);
            string uletra = palavra1.Substring(palavra1.Length - 1, 1);
            Console.WriteLine("a primeira letra é " + pletra);
            Console.WriteLine("a ultima letra é " + uletra);

            //8
            Console.WriteLine("Vou verificar se seu numero é do brasil");
            bool brasil = false;
            Console.WriteLine("Digite seu numero");
            string tel = Convert.ToString(Console.ReadLine());
            brasil = tel.Contains("+55");
            if (brasil == true)
            {
                Console.WriteLine("seu numero pertence ao Brasil");
            }
            else
            { Console.WriteLine("seu numero não é do brasil"); }

            //9
            Console.WriteLine("vou mudar as vogais da sua frase");
            Console.WriteLine("Digite a frase");
            string frase2 = Console.ReadLine();

            int a1 = frase2.IndexOf("a");
            frase2.Substring(a1, 4);

            int e = frase2.IndexOf("e");
            frase2.Substring(e, 3);

            int i = frase2.IndexOf("i");
            frase2.Substring(i, 1);

            int o = frase2.IndexOf("o");
            frase2.Substring(o, 0);

            int u = frase2.IndexOf("u");
            frase2.Substring(u, 9);

            Console.WriteLine("Sua frase ficou");
            Console.WriteLine(frase2);

            //10
            Console.WriteLine("vou tirar as letras da sua frase");
            Console.WriteLine("digite sua frase");
            var frase3 = Console.ReadLine();
            var apenasDigitos = new Regex(@"[^\d]");
            string frasetratada = apenasDigitos.Replace(frase3, "");
            Console.WriteLine("Sua frase ficou assim");
            Console.WriteLine(frasetratada);


            //11
            Console.WriteLine("Vou dizer seu primeiro nome");
            Console.WriteLine("informe seu nome completo");
            string primeironome = Console.ReadLine();
            primeironome.Substring(0, primeironome.IndexOf(" "));
            Console.WriteLine("O seu primerio nome é" + primeironome);

            //12
            Console.WriteLine("Vou dizer seu ultimo nome");
            Console.WriteLine("digite seu nome completo");
            string ultimonome = Console.ReadLine();
            ultimonome.Substring(primeironome.LastIndexOf(" "),ultimonome.Length);

            //SESSIONNINE

            //NIVEL1

            //a

            try
            {
                Console.WriteLine("Vou calcular a area de um triangulo");

                double baset = 0;
                double alturat = 0;
                double resultadot = 0;

                Console.WriteLine("digite a base");
                baset = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("digite a altura");
                alturat = Convert.ToDouble(Console.ReadLine());

                function.sessionine trigonometria = new function.sessionine();
                resultadot = trigonometria.calcareatriangulo(baset, alturat);

                Console.WriteLine("a area do triangulo é: "+resultadot);
            }
            
            catch(Exception)
            {
                Console.WriteLine("Erro verifique o formulario");
            }

            //b
            try
            {
                double raiot = 0;
                Console.WriteLine("Vou calcular a circunferencia ");
                Console.WriteLine("Digite o raio");
                raiot = Convert.ToDouble(Console.ReadLine());

                function.sessionine trigonometria = new function.sessionine();
                double resultadoc = trigonometria.calccircunferencia(raiot);

                Console.WriteLine("A circunferencia é: " + resultadoc);
            }


            catch(Exception)
            {
                Console.WriteLine("Erro verifique o formulario");
            }

               //c
                 try
                {        
                double pert = 0;

                Console.WriteLine("Vou calcular a area do octogono");

                Console.WriteLine("digite o lado");
                pert = Convert.ToDouble(Console.ReadLine());

                function.sessionine trigonometria = new function.sessionine();

                double resultadoo = trigonometria.calcperoctogono(pert);

                Console.WriteLine("O perimetro do seu octogno é: " + resultadoo);
            }

            catch (Exception)
            {
                Console.WriteLine("Erro verifique o formulario");
            }

            //NIVEL2


        }

            

        }



    }

