using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;
using Vehicle_Configurator.Repository;

namespace Vehicle_Configurator.Controllers
{
   
    [Route("api/invoicestore")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceRepository _repository;

        public InvoiceController(IInvoiceRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<ActionResult<Invoice>> AddInvoice(Invoice invoice)
        {
            var result = await _repository.AddInvoice(invoice);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}