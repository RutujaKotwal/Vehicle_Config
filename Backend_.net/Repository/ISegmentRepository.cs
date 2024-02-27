using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public interface ISegmentRepository
    {
        Task<ActionResult<IEnumerable<SegmentMaster>?>> GetSegments();
    }
}
