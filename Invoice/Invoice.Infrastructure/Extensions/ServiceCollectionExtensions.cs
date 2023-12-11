using Invoice.Domain.Interfaces;
using Invoice.Infrastructure.Persistence;
using Invoice.Infrastructure.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InvoiceDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("Invoice")));

            services.AddScoped<InvoiceSeeder>();

            services.AddScoped<IInvoiceRepository, IInvoiceRepository>();
        }
    }
}
