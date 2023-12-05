using Invoice.Domain.Entities;
using Invoice.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Infrastructure.Seeder
{
    public class InvoiceSeeder
    {
        private readonly InvoiceDbContext _dbContext;

        public InvoiceSeeder(InvoiceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if(!_dbContext.Invoices.Any())
                {
                    var TestInvoice = new Domain.Entities.Invoice()
                    {
                      CreatedAt= DateTime.Now,
                      Place ="Lodz",
                      AccountNumber = "1099 0000 0000 0000 9786",
                      Signature = "Company name"
                    };
                    _dbContext.Invoices.Add(TestInvoice);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
