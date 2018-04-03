using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    // khởi tạo các đối tượng Entity
   public interface IDBFactory:IDisposable
    {
        ThanhNguyenShopDbContext Init();
    }
}
