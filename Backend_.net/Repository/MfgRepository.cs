using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public class MfgRepository : IMfgRepository
    {
        private readonly ScottDbContext _dbContext;
        public MfgRepository(ScottDbContext context)
        {
            _dbContext = context;
        }

        public async Task<ActionResult<IEnumerable<MfgMaster>?>> GetMfgBySegid(int Id)
        {
            if (_dbContext.MfgMasters == null)
            {
                return null;
            }
            var mfgList = await _dbContext.MfgMasters
                .Where(m => m.SegId == Id)
                .ToListAsync();

            if (mfgList == null)
            {
                return new NotFoundResult();
            }
            return new ActionResult<IEnumerable<MfgMaster>>(mfgList);
        }
    }
}
