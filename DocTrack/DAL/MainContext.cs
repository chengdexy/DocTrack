﻿using DocTrack.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTrack.DAL
{
    class MainContext : DbContext
    {
        public MainContext() : base("MainContext") { }

        //DbSets
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<SubDocument> SubDocuments { get; set; }
        public DbSet<CirculationOperation> CirculationOperations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }



}
