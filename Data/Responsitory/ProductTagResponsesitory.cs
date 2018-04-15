using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IProductTagResponsesitory
    {

    }
   public class ProductTagResponsesitory :ResponsitoryBase<ProductTag>,IProductTagResponsesitory
    {
        public ProductTagResponsesitory(DbFactory dbFactory):base(dbFactory)
        {
        }

    }
}
