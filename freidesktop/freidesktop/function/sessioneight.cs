using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessioneight
    {
        //1
        public decimal calcmedia1(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            decimal total = 0;
            total = (n1 + n2 + n3 + n4 + recu) / 5;
            return total;
        }
        public bool vmedia(decimal total)
        {
            bool passou = false;
            if (total >= 5)
                passou = true;
            return passou;
        }
        //2
        public bool calcmedia2(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            decimal total = 0;
            bool passou = false;
            if (recu == 0)
            { total = n1 + n2 + n3 + n4 / 4; }
            else
            { total = (n1 + n2 + n3 + n4 + recu) / 5; }
            if (total >= 5)
            { passou = true; }

            return passou;
        }

        //3
        public string passouounao(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            string passou = "";

            if (((n1 + n2 + n3 + n4 + recu) / 5) >= 5)
            {
                passou = "voce passou";
            }
            else
            { passou = "voce nao passou"; }
            return passou;
        }

        //4
        public bool passaounaopassa(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            bool passa = false;
            while (((n1 + n2 + n3 + n4 + recu) / 5) >= 5)
            { passa = true; }

            return passa;
        }

        //5
        public string passar(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            string passa = "";
            decimal total = (n1 + n2 + n3 + n4) / 4;
            if (total < 5)
            { total = (n1 + n2 + n3 + n4 + recu) / 5; }
            if (total >= 5)
            { passa = "voce passou"; }
            else
            { passa = "nao passou"; }
            return passa;
        }

        //6
        public decimal calcmedia(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            decimal total = (n1 + n2 + n3 + n4) / 4;
            if (total < 5)
            {
                total = (n1 + n2 + n3 + n4 + recu) / 5;

            }
            return total;
        }
        //7
        public decimal mediacomrecuperacao(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            decimal total = (n1 + n2 + n3 + n4 + recu) / 5;
            return total;
        }
        //8
        private decimal calc2(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            decimal total = (n1 + n2 + n3 + n4) / 4;
            if (total < 5)
            {
                total = (n1 + n2 + n3 + n4 + recu) / 5;

            }
            return total;
        }
        public bool passou3(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            decimal nota = calc2(n1, n2, n3, n4, recu);
            bool passou = false;
            if (nota >= 5)
            {
                passou = true;
            }
            return passou;
        }
        //9
        private bool calc3(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            bool passou = false;
            decimal total = 0;

            if (recu == 0)
            { total = (n1 + n2 + n3 + n4) / 4; }
            else
            { total = (n1 + n2 + n3 + n4 + recu) / 5; }

            if (total >= 5)
            {
                passou = true;
            }
            return passou;
        }
        public string passounastring(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            string aviso = "";
            bool passou = calc3(n1, n2, n3, n4, recu);
            if (passou == true)
            {
                aviso = "voce passou";
            }
            else
            { aviso = "voce nao passou"; }
            return aviso;
        }
        //10
        public decimal nota(decimal n1, decimal n2, decimal n3, decimal n4, decimal recu)
        {
            decimal soma = n1 + n2 + n3+n4;
            decimal soma2 = n1 + n2 + n3 + n4+recu;
            decimal total = soma / 4;
            if(total<5)
            {
                total = soma2 / 5;
            }
            return total;
        }
    }
}
