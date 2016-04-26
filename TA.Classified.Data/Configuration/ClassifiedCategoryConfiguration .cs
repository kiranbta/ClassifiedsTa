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
            ToTable("TAC_Category");
            Property(c => c.CategoryName).IsRequired().HasMaxLength(50);
            Property(c => c.CategoryImage).IsOptional();
        }
    }
}
