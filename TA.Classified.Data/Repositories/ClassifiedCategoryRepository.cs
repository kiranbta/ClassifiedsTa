using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.Classified.Data.Infrastructure;
using TA.Classified.Model;

namespace TA.Classified.Data.Repositories
{
    public class ClassifiedCategoryRepository : RepositoryBase<ClassifiedCategory>, IClassifiedCategoryRepository
    {
        public ClassifiedCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public ClassifiedCategory GetCategoryByName(string categoryName)
        {
            var category = this.DbContext.ClassifiedCategories.Where(c => c.CategoryName == categoryName).FirstOrDefault();

            return category;
        }
    }

    public interface IClassifiedCategoryRepository : IRepository<ClassifiedCategory>
    {
        ClassifiedCategory GetCategoryByName(string categoryName);
    }
}
