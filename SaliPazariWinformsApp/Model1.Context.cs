﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaliPazariWinformsApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SaliPazari_DBEntities : DbContext
    {
        public SaliPazari_DBEntities()
            : base("name=SaliPazari_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alimlar> Alimlars { get; set; }
        public virtual DbSet<Ilceler> Ilcelers { get; set; }
        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Markalar> Markalars { get; set; }
        public virtual DbSet<SatisDetaylar> SatisDetaylars { get; set; }
        public virtual DbSet<Satislar> Satislars { get; set; }
        public virtual DbSet<Sehirler> Sehirlers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tedarikciler> Tedarikcilers { get; set; }
        public virtual DbSet<Yoneticiler> Yoneticilers { get; set; }
        public virtual DbSet<YoneticiYetkiler> YoneticiYetkilers { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }
    }
}
