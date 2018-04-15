using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface ITagResponsesitory
    {

    }
    public class TagResponsesitory:ResponsitoryBase<Tag>,ITagResponsesitory
    {
        public TagResponsesitory(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
