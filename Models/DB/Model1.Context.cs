﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zero_hunger.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class zero_hungerEntities : DbContext
    {
        public zero_hungerEntities()
            : base("name=zero_hungerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<collect_request> collect_request { get; set; }
        public virtual DbSet<food> foods { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
