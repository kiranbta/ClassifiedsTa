using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA.Classified.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ClassifiedEntities Init();
    }
}
