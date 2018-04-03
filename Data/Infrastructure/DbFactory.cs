using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
   public class DbFactory : Disposable, IDBFactory
    {
        ThanhNguyenShopDbContext dbContext;
        public ThanhNguyenShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ThanhNguyenShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
