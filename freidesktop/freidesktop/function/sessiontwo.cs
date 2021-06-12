using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.function
{
    class sessiontwo
    {
    public double vquiz(int p1, int p2, int p3, int p4, int p5 )
    {
            int total = 0;

            if( p1 == 1)
            {
                total += 1;
            }
            if (p2 ==3)
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

    }
}
