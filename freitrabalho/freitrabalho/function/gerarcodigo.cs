using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.function
{
    class gerarcodigo
    {public int gcodigo ()
        {
            Random randNum = new Random();
            int codigo = 0;
            for (int i = 0; i <= 1; i++)
            { codigo = Convert.ToInt32((randNum.Next())); }
            return codigo;
        }
     
}
}
