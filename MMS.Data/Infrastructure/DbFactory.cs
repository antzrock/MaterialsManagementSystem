using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        MMSContext dbContext;

        public MMSContext Init()
        {
            return dbContext ?? (dbContext = new MMSContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
