﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Training_18Apr19_Cloud_CGKPEntities : DbContext
    {
        public Training_18Apr19_Cloud_CGKPEntities()
            : base("name=Training_18Apr19_Cloud_CGKPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employer_180623> Employer_180623 { get; set; }
        public virtual DbSet<Job_180623> Job_180623 { get; set; }
        public virtual DbSet<JobSeeker_180623> JobSeeker_180623 { get; set; }
        public virtual DbSet<Resume_180623> Resume_180623 { get; set; }
        public virtual DbSet<Approved_180623> Approved_180623 { get; set; }
    }
}