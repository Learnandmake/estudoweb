﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace freientity2._0.database.entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class schooldbEntities : DbContext
    {
        public schooldbEntities()
            : base("name=schooldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbaluno> tbaluno { get; set; }
        public virtual DbSet<tbmedia> tbmedia { get; set; }
        public virtual DbSet<tbturma> tbturma { get; set; }
    }
}
