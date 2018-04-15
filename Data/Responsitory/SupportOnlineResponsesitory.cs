using Data.Infrastructure;
using Model.Model;

namespace Data.Responsitory
{
    public interface ISupportOnlineResponsesitory
    {
    }

    public class SupportOnlineResponsesitory : ResponsitoryBase<SupportOnline>, ISupportOnlineResponsesitory
    {
        public SupportOnlineResponsesitory(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}