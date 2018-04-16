using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IOrderDetailResponsesitory
    {

    }

   public class OrderDetailResponsesitory : ResponsitoryBase<OrderDetail>, IOrderDetailResponsesitory
    {
        public OrderDetailResponsesitory(DbFactory dbFactory) : base(dbFactory)
        {
            string s = "";
        }
    }
}
