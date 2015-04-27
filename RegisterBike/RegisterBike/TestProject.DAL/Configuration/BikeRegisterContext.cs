using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Model;

namespace TestProject.DAL.Configuration
{
    /// <summary>
    /// Data base conext where conect data with database 
    /// RegisterContext- name connection string
    /// </summary>
    public class BikeRegisterContext : DbContext
    {
        public BikeRegisterContext()
            : base("RegisterContext")
        {
            Bikes = this.Set<Bike>();
        }
        
        /// <summary>
        /// Bikes data set (data table)
        /// </summary>
        public DbSet<Bike> Bikes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
