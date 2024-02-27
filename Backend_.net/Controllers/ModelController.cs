using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;
using Vehicle_Configurator.Repository;

namespace Vehicle_Configurator.Controllers
{
    [Route("api/Model")]
    [ApiController]
    public class ModelController : Controller
    {
        public readonly IModelRepository repository;
        public ModelController(IModelRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("{segid}/{mfgid}")]
        public async Task<ActionResult<IEnumerable<ModelMaster>?>> GetModelbysegandmfg(int segid ,int mfgid)
        {
            if (await repository.GetModelbySegandMfg(segid,mfgid) == null)
            {
                return NotFound();
            }
            return await repository.GetModelbySegandMfg(segid,mfgid);

        }
    }
}
