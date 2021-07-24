using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace freioficina.model
{
    public class livromodel
    {
        [Display(Name="ID:")]
        public int idlivro { get; set; }
        [Display(Name = "Titulo:")]
        public string nmlivro { get; set; }
        [Display(Name = "Nome do autor:")]
        public string nmautor { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de lançamento:")]    
        public DateTime dtlancamento { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de leitura:")]
        public DateTime dtleitura { get; set; }
        [Display(Name = "Já lido:")]
        public bool lido { get; set; }
    }
}