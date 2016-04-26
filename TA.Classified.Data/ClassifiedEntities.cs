using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.Classified.Data.Configuration;
using TA.Classified.Model;

namespace TA.Classified.Data
{
    public class ClassifiedEntities : DbContext
    {
        public ClassifiedEntities() : base("ClassifiedEntities") { }
                
        public DbSet<ClassifiedCategory> ClassifiedCategories { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClassifiedCategoryConfiguration());
        }
    }
}
