using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface ISlideResponesitory
    {

    }
   public class SlideResponesitory: ResponsitoryBase<Slide>,ISlideResponesitory
    {
        public SlideResponesitory(DbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
