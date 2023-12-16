using Invoice.Domain.Interfaces;
using Invoice.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Infrastructure.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly InvoiceDbContext _dbContext;
        public InvoiceRepository(InvoiceDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.Invoice invoice)
        {
            _dbContext.Add(invoice);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.Invoice>> GetAll()
        =>await _dbContext.Invoices.ToListAsync();

    }
}
