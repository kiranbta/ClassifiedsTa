using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.Classified.Data.Infrastructure;
using TA.Classified.Data.Repositories;
using TA.Classified.Model;

namespace TA.Classified.Business
{
    // operations you want to expose
    public interface ICategoryService
    {
        IEnumerable<ClassifiedCategory> GetCategories(string name = null);
        ClassifiedCategory GetCategory(int id);
        ClassifiedCategory GetCategory(string name);
        void CreateCategory(ClassifiedCategory category);
        void SaveCategory();
    }

    public class CategoryService : ICategoryService
    {
        private readonly IClassifiedCategoryRepository categorysRepository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(IClassifiedCategoryRepository categorysRepository, IUnitOfWork unitOfWork)
        {
            this.categorysRepository = categorysRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ICategoryService Members

        public IEnumerable<ClassifiedCategory> GetCategories(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return categorysRepository.GetAll();
            else
                return categorysRepository.GetAll().Where(c => c.CategoryName == name);
        }

        public ClassifiedCategory GetCategory(int id)
        {
            var category = categorysRepository.GetById(id);
            return category;
        }

        public ClassifiedCategory GetCategory(string name)
        {
            var category = categorysRepository.GetCategoryByName(name);
            return category;
        }

        public void CreateCategory(ClassifiedCategory category)
        {
            categorysRepository.Add(category);
        }

        public void SaveCategory()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
