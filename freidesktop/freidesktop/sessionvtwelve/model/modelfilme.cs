using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.sessionvtwelve.model
{
    class modelfilme
    {
        public int idfilme { get; set; }
        public string nome { get; set; }
        public decimal avaliacao { get; set; }
        public bool disponivel { get; set; }
        public DateTime dtestreia { get; set; }
    }
}
