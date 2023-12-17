using AutoMapper;
using Invoice.Domain.Interfaces;
using MediatR;

namespace Invoice.Application.Invoice.Queries.GetAllInvoices
{
    public class GetAllInvoicesQueryHandler : IRequestHandler<GetAllInvoicesQuery, IEnumerable<InvoiceDto>>
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public GetAllInvoicesQueryHandler(IInvoiceRepository invoiceRepository,IMapper mapper) 
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<InvoiceDto>> Handle(GetAllInvoicesQuery request, CancellationToken cancellationToken)
        {
            var invoices = await _invoiceRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<InvoiceDto>>(invoices);
            return dtos;
        }
    }
}
