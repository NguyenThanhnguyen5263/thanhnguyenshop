using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IMenuGroupResponesitory
    {
          
    }
   public class MenuGroupResponesitory : ResponsitoryBase<MenuGroup>,IMenuGroupResponesitory
    {
        public MenuGroupResponesitory(DbFactory dbFactory):base(dbFactory)
        {
                
        }
            
    }
}
