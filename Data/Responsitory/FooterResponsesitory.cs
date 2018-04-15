using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IFooterResponsesitory
    {      
    }
    public class FooterResponsesitory:ResponsitoryBase<Footer>, IFooterResponsesitory
    {
        public FooterResponsesitory(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
