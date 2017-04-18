using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquariumEntityFramework.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AquariumEntityFramework.DataContext
{
    class AquariumContext :DbContext
    {
        public AquariumContext():base()
        {

        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Aquarium> Aquariums { get; set; }
        public DbSet<AquaticLife> AquaticLifes { get; set; }
        public DbSet<Ocean> Oceans { get; set; }

    }
}
