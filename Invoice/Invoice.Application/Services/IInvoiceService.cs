namespace Invoice.Application.Services
{
    public interface IInvoiceService
    {
        Task Create(Domain.Entities.Invoice invoice);
    }
}