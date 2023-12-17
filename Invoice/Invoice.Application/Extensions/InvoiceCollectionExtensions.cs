using Invoice.Application.Invoice.Commands.CreateInvoice;
using Invoice.Application.Mappings;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Invoice.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateInvoiceCommand));
            services.AddAutoMapper(typeof(InvoiceMappingProfile));
        }
    }
}
