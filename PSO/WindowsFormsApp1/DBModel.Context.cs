﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PSOConnect : DbContext
    {
        public PSOConnect()
            : base("name=PSOConnect")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<coordinator> coordinator { get; set; }
        public virtual DbSet<department> department { get; set; }
        public virtual DbSet<disaster> disaster { get; set; }
        public virtual DbSet<equipment> equipment { get; set; }
        public virtual DbSet<mainDepartment> mainDepartment { get; set; }
        public virtual DbSet<missingPeople> missingPeople { get; set; }
        public virtual DbSet<people> people { get; set; }
        public virtual DbSet<profession> profession { get; set; }
        public virtual DbSet<reason> reason { get; set; }
        public virtual DbSet<region> region { get; set; }
        public virtual DbSet<team> team { get; set; }
        public virtual DbSet<teamPosition> teamPosition { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}