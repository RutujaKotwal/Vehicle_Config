using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;
using Vehicle_Configurator.Repository;

namespace Vehicle_Configurator.Controllers
{
    [Route("api/mfgbyid")]
    [ApiController]
    public class MfgController:ControllerBase
    {
        public readonly IMfgRepository _repository;
        public MfgController(IMfgRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<MfgMaster>?>> GetMfgBySegid(int id)
        {
            var Mfg = await _repository.GetMfgBySegid(id);
            return Mfg == null ? NotFound() : Mfg;
        }

    }
}
