﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto02_WCFPagamentos.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_PAGAMENTOSEntities : DbContext
    {
        public DB_PAGAMENTOSEntities()
            : base("name=DB_PAGAMENTOSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cartao> Cartoes { get; set; }
        public virtual DbSet<Pagamento> Pagamentos { get; set; }
    }
}
