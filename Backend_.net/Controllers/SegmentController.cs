using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;
using Vehicle_Configurator.Repository;

namespace Vehicle_Configurator.Controllers
{
    [Route("api/segments")]
    [ApiController]
    public class SegmentController:ControllerBase
    {
        public readonly ISegmentRepository _repository;
        public SegmentController(ISegmentRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SegmentMaster>?>> GetSegments()
        {
            if (await _repository.GetSegments() == null)
            {
                return NotFound();
            }

            return await _repository.GetSegments();
        }
    }
}
