using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private EnglishOnlineDbContext dbContext;

        public EnglishOnlineDbContext Init()
        {
            return dbContext ?? (dbContext = new EnglishOnlineDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
