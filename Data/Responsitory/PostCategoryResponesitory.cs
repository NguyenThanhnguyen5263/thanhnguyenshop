using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IPostCategoryResponesitory
    {

    }
   public  class PostCategoryResponesitory: ResponsitoryBase<PostCategory>,IPostCategoryResponesitory
    {
        PostCategoryResponesitory(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
