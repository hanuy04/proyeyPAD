﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyekPAD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_uniqloEntities : DbContext
    {
        public db_uniqloEntities()
            : base("name=db_uniqloEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<barang> barangs { get; set; }
        public virtual DbSet<diskon> diskons { get; set; }
        public virtual DbSet<voucher> vouchers { get; set; }
    }
}
