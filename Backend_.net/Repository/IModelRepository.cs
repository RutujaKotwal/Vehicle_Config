using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public interface IModelRepository
    {
       Task<ActionResult<IEnumerable<ModelMaster>?>> GetModelbySegandMfg(int segid,int mfgid);
    }
}
