using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public class SegmentRepository : ISegmentRepository
    {
        public readonly ScottDbContext _dbcontext;
        public SegmentRepository(ScottDbContext context)
        {
            _dbcontext = context;
        }
        public async Task<ActionResult<IEnumerable<SegmentMaster>?>> GetSegments()
        {
            if (_dbcontext.SegmentMasters == null)
            {
                return null;
            }
            return await _dbcontext.SegmentMasters.ToListAsync();
        }
    }
}
