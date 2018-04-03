using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBFactory dbFactory;
        private ThanhNguyenShopDbContext dbContext;

        public UnitOfWork(IDBFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ThanhNguyenShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
