﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessPoliza
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GestionPolizaEntities : DbContext
    {
        public GestionPolizaEntities()
            : base("name=GestionPolizaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AsignacionPoliza> AsignacionPoliza { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<EstadoPoliza> EstadoPoliza { get; set; }
        public virtual DbSet<Poliza> Poliza { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoCubrimiento> TipoCubrimiento { get; set; }
        public virtual DbSet<TipoRiesgo> TipoRiesgo { get; set; }
    }
}
