using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessioneight
    {
    public decimal calcmedia1(decimal n1, decimal n2, decimal n3, decimal n4)
    {    decimal total = 0;
         total = (n1 + n2 + n3 + n4) / 4; 
         return total;
    }
    public bool vmedia (decimal total)
    {
            bool passou = false;
            if (total >= 5)
                passou = true;
    return passou;
    }
    }
}
