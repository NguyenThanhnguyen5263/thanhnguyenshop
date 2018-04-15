using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IVisitorStatisticResponsesitory
    {

    }
    public class VisitorStatisticResponsesitory:ResponsitoryBase<VisitorStatistic>,IVisitorStatisticResponsesitory
    {
        public VisitorStatisticResponsesitory(DbFactory dbFactory):base(dbFactory)
        {
                
        }

    }
}
