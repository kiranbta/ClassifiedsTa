using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA.Classified.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ClassifiedEntities dbContext;

        public ClassifiedEntities Init()
        {
            return dbContext ?? (dbContext = new ClassifiedEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
