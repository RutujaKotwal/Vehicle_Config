using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public interface IMfgRepository
    {
        Task<ActionResult<IEnumerable<MfgMaster>?>> GetMfgBySegid(int Id);
    }
}
