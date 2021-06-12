using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessiontwo
    {
        public double vquiz(int p1, int p2, int p3, int p4, int p5)
        {
            int total = 0;

            if (p1 == 1)
            {
                total += 1;
            }
            if (p2 == 3)
            {
                total += 1;
            }

            if (p3 == 1)
            {
                total += 1;
            }

            if (p4 == 2)
            {
                total += 1;
            }

            if (p5 == 3)
            {
                total += 1;
            }

            return total;
        }


        public double totalorcamento(int processador, int hd, int ram, int pv)
        {
            double pro1 = this.precoprocessador(processador);
            double hd1 = this.precohd(hd);
            double ram1 = this.precoram(ram);
            double pv1 = this.precopv(pv);

            double total = pro1 + hd1 + ram1 + pv1;
            return total;
        }

        private double precoprocessador(int opcao)
        {
        if(opcao == 1)
             return 300; 
        
          else  if (opcao == 2)
             return 700; 

           else if (opcao == 3)
            return 1200;

            else
            return 0;
        }

        private double precohd(int opcao)
        {
            if (opcao == 1)
                return 100;

            else if (opcao == 2)
                return 300;

            else if (opcao == 3)
                return   700;

            else
                return 0;
        }

        private double precoram(int opcao)
        {
            if (opcao == 1)
                return 200;

            else if (opcao == 2)
                return 50;

            else if (opcao == 3)
                return 70;

            else
                return 0;
        }

        private double precopv(int opcao)
        {
            if (opcao == 1)
                return 3000;

            else if (opcao == 2)
                return 1500;

            else if (opcao == 3)
                return 2000;

            else
                return 0;
        }
    }
}
