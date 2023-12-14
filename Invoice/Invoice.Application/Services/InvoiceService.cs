using AutoMapper;
using Invoice.Application.Invoice;
using Invoice.Domain.Interfaces;

namespace Invoice.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;
        public InvoiceService(IInvoiceRepository invoiceRepository,IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _mapper=mapper;
        }
        public async Task Create(InvoiceDto invoiceDto)
        {
            var invoice = _mapper.Map<Domain.Entities.Invoice>(invoiceDto);
            await _invoiceRepository.Create(invoice);
        }
    }
}
