﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TreeToolOrebrollEntities : DbContext
    {
        public TreeToolOrebrollEntities()
            : base("name=TreeToolOrebrollEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ActionNeedsTimeType> ActionNeedsTimeType { get; set; }
        public DbSet<ActionNeedsType> ActionNeedsType { get; set; }
        public DbSet<AgeType> AgeType { get; set; }
        public DbSet<DamageClassType> DamageClassType { get; set; }
        public DbSet<DiseasesType> DiseasesType { get; set; }
        public DbSet<Estate> Estate { get; set; }
        public DbSet<FungusType> FungusType { get; set; }
        public DbSet<Performer> Performer { get; set; }
        public DbSet<SafetyType> SafetyType { get; set; }
        public DbSet<Tree> Tree { get; set; }
        public DbSet<TreeInventory> TreeInventory { get; set; }
        public DbSet<TreeSpecies> TreeSpecies { get; set; }
        public DbSet<VitalityType> VitalityType { get; set; }
    }
}
