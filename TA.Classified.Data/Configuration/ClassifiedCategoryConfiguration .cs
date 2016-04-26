using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.Classified.Model;

namespace TA.Classified.Data.Configuration
{
    public class ClassifiedCategoryConfiguration : EntityTypeConfiguration<ClassifiedCategory>
    {
        public ClassifiedCategoryConfiguration() 
        {
            ToTable("Categories");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
