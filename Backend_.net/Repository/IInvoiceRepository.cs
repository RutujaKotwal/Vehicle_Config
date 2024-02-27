using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public interface IInvoiceRepository
    {
        Task<ActionResult<Invoice>?> AddInvoice(Invoice invoice);
    }
}
