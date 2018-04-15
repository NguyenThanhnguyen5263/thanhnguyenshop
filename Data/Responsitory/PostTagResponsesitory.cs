using Data.Infrastructure;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Responsitory
{
    public interface IPostTagResponsesitory
    {

    }
    public class PostTagResponsesitory : ResponsitoryBase<PostTag>,IPostTagResponsesitory
    {
        public PostTagResponsesitory(DbFactory dbFactory): base (dbFactory)
        {

        }
    }
}
