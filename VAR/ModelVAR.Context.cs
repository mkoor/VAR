﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VAR
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VAREntities : DbContext
    {
        public VAREntities()
            : base("name=VAREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AutopartsSet> AutopartsSet { get; set; }
        public virtual DbSet<ClientsSet> ClientsSet { get; set; }
        public virtual DbSet<DepartmentsSet> DepartmentsSet { get; set; }
        public virtual DbSet<OrdersSet> OrdersSet { get; set; }
        public virtual DbSet<StaffSet> StaffSet { get; set; }
        public virtual DbSet<SuppliersSet> SuppliersSet { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
