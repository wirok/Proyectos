﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrazaNet.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrazaNetEntitiesContext : DbContext
    {
        public TrazaNetEntitiesContext()
            : base("name=StrConnTrazaNetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ABERTURARED> ABERTURARED { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CENTROS> CENTROS { get; set; }
        public virtual DbSet<CICLOSCENTRO> CICLOSCENTRO { get; set; }
        public virtual DbSet<CROTAL> CROTAL { get; set; }
        public virtual DbSet<DENIERRED> DENIERRED { get; set; }
        public virtual DbSet<EMPRESAS> EMPRESAS { get; set; }
        public virtual DbSet<FIGURARED> FIGURARED { get; set; }
        public virtual DbSet<FUNCIONRED> FUNCIONRED { get; set; }
        public virtual DbSet<JAULA> JAULA { get; set; }
        public virtual DbSet<MEDIDARED> MEDIDARED { get; set; }
        public virtual DbSet<MODULOS> MODULOS { get; set; }
        public virtual DbSet<MOVIMIENTO> MOVIMIENTO { get; set; }
        public virtual DbSet<MOVIMIENTORED> MOVIMIENTORED { get; set; }
        public virtual DbSet<PERSONAS> PERSONAS { get; set; }
        public virtual DbSet<RED> RED { get; set; }
        public virtual DbSet<SERVICIOBUCEO> SERVICIOBUCEO { get; set; }
        public virtual DbSet<TALLER> TALLER { get; set; }
        public virtual DbSet<TELARED> TELARED { get; set; }
        public virtual DbSet<TIPORED> TIPORED { get; set; }
        public virtual DbSet<TRANSPORTE> TRANSPORTE { get; set; }
    }
}
