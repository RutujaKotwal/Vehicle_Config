using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.Models;
using Vehicle_Configurator.Repository;

namespace Vehicle_Configurator.Controllers
{
    [Route("api/")]
    [ApiController]
    public class VehicleDetailController : ControllerBase
    {
        private readonly IVehicleDetailRepository _repository;

        public VehicleDetailController(IVehicleDetailRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("componentbyc/{mdl_id}")]
        public async Task<IEnumerable<string>?> GetByCore(int mdl_id)
        {


            var components = await _repository.GetVehicleDetailsByCore(mdl_id);
            return components;


        }
        [HttpGet("componentbye/{mdl_id}")]
        public async Task<IEnumerable<String>> GetByExt(int mdl_id)
        {
            var comp = await _repository.GetVehicleDetailsByExterior(mdl_id);
            return comp;
        }

        [HttpGet("componentbyi/{mdl_id}")]
        public async Task<IEnumerable<String>> GetByInt(int mdl_id)
        {
            var comp = await _repository.GetVehicleDetailsByInterior(mdl_id);
            return comp;
        }

        [HttpGet("componentbys/{mdl_id}")]
        public async Task<IEnumerable<String>> GetByStd(int mdl_id)
        {
            var comp = await _repository.GetVehicleDetailsByStandard(mdl_id);
            return comp;
        }

        [HttpGet("price/{mdl_id}")]
        public async Task<Price?> GetPrice(int mdl_id)
        {
            var price = await _repository.GetPrice(mdl_id);
            return price;
        }

        [HttpGet("image/{mdl_id}")]
        public async Task<String?> GetImg(int mdl_id)
        {
            var imgPath = await _repository.GetImagebyId(mdl_id);
            return imgPath;
        }


    }
}
