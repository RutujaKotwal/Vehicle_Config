using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.Models;
using Vehicle_Configurator.Repository;

namespace Vehicle_Configurator.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AlternatecomponentController : ControllerBase
    {

        private readonly IAlternatecomponentmasterRepository _altcomp;

        public AlternatecomponentController(IAlternatecomponentmasterRepository altcomp)
        {
            _altcomp = altcomp;
        }


        [HttpGet("std/{mdl_id}")]
        public List<String> GetCompnameByStd(int mdl_id)
        {
            return _altcomp.GetCompnameByStd(mdl_id);
        }

        [HttpGet("interior/{mdl_id}")]
        public List<String> GetCompnameByInt(int mdl_id)
        {
            return _altcomp.GetCompnameByInt(mdl_id);
        }

        [HttpGet("exterior/{mdl_id}")]
        public List<String> GetCompnameByExt(int mdl_id)
        {
            return _altcomp.GetCompnameByExt(mdl_id);
        }

        [HttpGet("invoice/{alt_id}")]
        public SubCompPrice GetFinalConfig(int alt_id)
        {
            return _altcomp.GetFinalConfig(alt_id);
        }

        [HttpGet("config/{mdl_id}/{Comp_name}")]
        public List<SubCompPrice> GetConfigurableConfig(int mdl_id, string Comp_name)
        {
            return _altcomp.GetConfigurableConfig(mdl_id, Comp_name);
        }


    }
}

