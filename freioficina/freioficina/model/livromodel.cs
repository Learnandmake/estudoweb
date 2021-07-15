using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace freioficina.model
{
    public class livromodel
    {public int idlivro { get; set; }
    public string nmlivro { get; set; }
    public string nmautor { get; set; }
    public DateTime dtlancamento { get; set; }
    public DateTime leitura { get; set; }
    public bool lido { get; set; }
    }
}