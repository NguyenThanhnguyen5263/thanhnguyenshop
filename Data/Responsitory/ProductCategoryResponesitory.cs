using Data.Infrastructure;
using Model;
using Model.Model;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Data.Responsitory
{
    public interface IProductCategoryResponesitory
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryResponesitory : ResponsitoryBase<ProductCategory>,IProductCategoryResponesitory
    {
       
        public ProductCategoryResponesitory(DbFactory dbFactory) : base(dbFactory)
        {
                
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategorys.Where(x => x.Alias == alias);

        }
    }
}