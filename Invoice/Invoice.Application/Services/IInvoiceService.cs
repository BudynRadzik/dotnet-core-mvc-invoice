using Invoice.Application.Invoice;

namespace Invoice.Application.Services
{
    public interface IInvoiceService
    {
        Task Create(InvoiceDto invoice);
    }
}