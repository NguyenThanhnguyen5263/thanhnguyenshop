using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IProductResponesitory
    {
            
    }
   public class ProductResponesitory : ResponsitoryBase<Product>, IProductResponesitory
    {
        public ProductResponesitory(IDBFactory dbFactory) :base(dbFactory)
        {

        }
        public IEnumerable<Product> GetByAlias(string alias)
        {
            return this.DbContext.Products.Where(x => x.Alias == alias);
        }
    }
}
