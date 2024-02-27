using Microsoft.AspNetCore.Mvc;
using Vehicle_Configurator.DbRepos;

namespace Vehicle_Configurator.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ScottDbContext context;

        public InvoiceRepository(ScottDbContext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<Invoice>?> AddInvoice(Invoice invoice)
        {
            context.Invoices.Add(invoice);
            await context.SaveChangesAsync();
            return invoice;
        }
    }
}