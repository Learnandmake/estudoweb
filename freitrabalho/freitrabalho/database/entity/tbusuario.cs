//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace freitrabalho.database.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbusuario
    {
        public tbusuario()
        {
            this.tblogin = new HashSet<tblogin>();
            this.tbpontuacao = new HashSet<tbpontuacao>();
        }
    
        public int idusuario { get; set; }
        public string nick { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> registro { get; set; }
    
        public virtual ICollection<tblogin> tblogin { get; set; }
        public virtual ICollection<tbpontuacao> tbpontuacao { get; set; }
    }
}
