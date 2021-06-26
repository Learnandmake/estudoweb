using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessionsix
    {public decimal calctotal(string filme,decimal qtdinteira, decimal qtdmeia, string cupom, DateTime dia)
        {   int vlbf = 0;
            string day = dia.DayOfWeek.ToString();
            decimal total = 0;

            if (filme == "Harry potter")
            {
                vlbf = 5; 

                total = vlbf * qtdinteira + ((qtdmeia * vlbf) / 2);
            }
            if (filme == "Velozes e furiosos")
            {
                vlbf = 7;
                total = vlbf * qtdinteira + ((qtdmeia * vlbf) / 2);
            }
            if (filme == "Avengers")
            {
                vlbf = 10;
                total = vlbf * qtdinteira + ((qtdmeia * vlbf) / 2);
            }

            if (day == "Wednesday")
            {
                total = total / 2;
            }
            if(cupom == "freimovies")
            {
                total = total-((total / 100) * 10);
            }

            return total;
        }
    }
}
