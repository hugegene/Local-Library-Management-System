﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SA45Team13bLibraryEntities : DbContext
    {
        public SA45Team13bLibraryEntities()
            : base("name=SA45Team13bLibraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookList> BookList { get; set; }
        public virtual DbSet<DueTran> DueTran { get; set; }
        public virtual DbSet<IssueTran> IssueTran { get; set; }
        public virtual DbSet<LibraryMember> LibraryMember { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<BookIssued> BookIssued { get; set; }
        public virtual DbSet<BookRequested> BookRequested { get; set; }
    }
}