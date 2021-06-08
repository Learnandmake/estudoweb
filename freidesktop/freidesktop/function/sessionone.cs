using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessionone
    {
        public int calcfmc(int idade)
        {
            int resultado = 220 - idade;
            return resultado;
        }
        public double calcimc(double peso, double altura)
        {
            double resultado = (peso / (Math.Pow(altura, 2)));
            Math.Round(resultado, 2);
            return resultado;
        }

        public bool vmidade(int idade)
        {
            bool re = false;

            if(idade>=18)
            {
                re = true;
            }
            else
            {
                re = false;
            }
            return re;
        }

        public double  calccaloria(int opcaocomida, int opcaobebida, int opcaosobremesa)
        {
            double comida = this.calccomida(opcaocomida);
            double bebida = this.calcbebida(opcaobebida);
            double sobremesa= this.calcsobremesa(opcaosobremesa);

            double total = comida + bebida + sobremesa;
            return total;
        }

        private double calcsobremesa(int opcao)
        {
            if (opcao == 1)

                return 350;


     
            else if (opcao == 2)

                return 270;

            else if (opcao == 3)

                return 300;

            else
                return 0;
        }

        private double calccomida(int opcao)
        {
            if (opcao == 1)

                return 300;


            else if (opcao == 2)

                return 400;

            else if (opcao == 3)

                return 100;

            else
                return 0;
        }

        private double calcbebida(int opcao)
        {
            if (opcao == 1)

                return 350;


            else if (opcao == 2)

                return 270;

            else if (opcao == 3)

                return 300;

            else
                return 0;
        }

        public string cor (string cor1, string cor2)
        {

            if (cor1 == "amarelo" && cor2 == "azul" || cor2 == "amarelo" && cor1 == "azul")
            
                return "verde";
               
            
            else if (cor1 == "vermelho" && cor2 == "azul" || cor2 == "vermelho" && cor1 == "azul")

                return "roxo";
         
            
            else if (cor1 == "amarelo" && cor2 == "vermelho"|| cor2 == "amarelo" && cor1 == "vermelho")

                return "laranja";

            return"cor irregular"; 

           
        }

        public int diasdevida(DateTime nascimento)
        {
            DateTime now = DateTime.Now;
            TimeSpan dif = now - nascimento;
            int totaldays = Convert.ToInt32(dif.TotalDays);
            return totaldays;
        }


    }
}
