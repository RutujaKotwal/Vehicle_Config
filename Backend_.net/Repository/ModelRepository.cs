using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public class ModelRepository : IModelRepository
    {
        public readonly ScottDbContext _dbContext;
        public ModelRepository(ScottDbContext context)
        {
            _dbContext = context;
        }

        async Task<ActionResult<IEnumerable<ModelMaster>?>> IModelRepository.GetModelbySegandMfg(int segid, int mfgid)
        {
            if (_dbContext.ModelMasters == null)
            {
                return null;
            }
            var ModelList = await _dbContext.ModelMasters
                .Where(m => m.SegId == segid && m.MfgId == mfgid).ToListAsync();
                

            if (ModelList == null)
            {
                return new NotFoundResult();
            }
            return new ActionResult<IEnumerable<ModelMaster>>(ModelList);

        }
    }
}
