using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface ISystemConfigResponsesitory
    {

    }
    public class SystemConfigResponsesitory : ResponsitoryBase<SystemConfig>,ISystemConfigResponsesitory
    
    {
        public SystemConfigResponsesitory(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
