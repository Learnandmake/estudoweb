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
        {
            function.intensivo intensivo = new function.intensivo();


            //1.exercicio
            Console.WriteLine("informe a nota 1:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota 2:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota 3:");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota 4:");
            double n4 = Convert.ToDouble(Console.ReadLine());

          
            double media = intensivo.calcularmedia(n1, n2, n3, n4);
            string sugestao = intensivo.darsugestao(media);

            Console.WriteLine("Sua media é: " + media);
            Console.WriteLine(sugestao);

            //2.exercicio
            Console.WriteLine("Escolha sua operação:");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potência");
            Console.WriteLine("6. Raiz quadrada");
            int opcao = Convert.ToInt32(Console.ReadLine());

            double resposta = 0;
            Console.WriteLine("Informe o numero 1:");
            double n5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o numero 2:");
            double n6 = Convert.ToDouble(Console.ReadLine());

            if (opcao ==1)
            { resposta = intensivo.somar(n5, n6); }

            else if (opcao == 2)
            { resposta = intensivo.subtrair(n5, n6); }
            else if (opcao == 3)
            { resposta = intensivo.multiplicar(n5, n6); }

            else if (opcao == 4)
            { resposta = intensivo.dividir(n5, n6); }

            if (opcao ==5 )
            { Console.WriteLine("Informe o numero:");
                double n7 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a potencia:");
                double np = Convert.ToDouble(Console.ReadLine());

                resposta = intensivo.potencia(n7, np);
            }

            if(opcao == 6)
            {
                Console.WriteLine("Informe o numero:");

                double n8 = Convert.ToDouble(Console.ReadLine());

                resposta = intensivo.raizquadrada(n8);
                
            }

            Console.WriteLine(resposta);

            //3.exercicio

            Console.WriteLine("Informe uma cor:");
            string cor = Console.ReadLine();


            bool r = intensivo.corprimaria(cor);

            if(r == true)
            {
                Console.WriteLine("é uma cor primaria");

            }

            else
            {
                Console.WriteLine("nao e uma cor primaria");
            }

            //4.exercicio
            Console.WriteLine("Informe a opcao para comida");

            Console.WriteLine("1.fastfood");
            Console.WriteLine("2.churras");
            Console.WriteLine("3.lanche natural");
            int opcaocomida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a opcao para bebida");
            Console.WriteLine("1.coca-cola");
            Console.WriteLine("2.suco caixa");
            Console.WriteLine("3.suco natural");
            int opcaobebida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a opcao para sobremessa");
            Console.WriteLine("1.açai");
            Console.WriteLine("2.bolo");
            Console.WriteLine("3.mousse");
            int opcaosobremessa = Convert.ToInt32(Console.ReadLine());

            double resultado = intensivo.calcularcalorias(opcaocomida, opcaobebida, opcaosobremessa);

            Console.WriteLine("O total de calorias foi de" + r);

        }
    }
}
