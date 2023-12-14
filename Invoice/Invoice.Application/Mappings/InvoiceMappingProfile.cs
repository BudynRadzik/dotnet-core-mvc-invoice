using AutoMapper;
using Invoice.Application.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Application.Mappings
{
    public class InvoiceMappingProfile : Profile
    {
        public InvoiceMappingProfile()
        {
            CreateMap<InvoiceDto, Domain.Entities.Invoice>()
                .ForMember(e => e.Place, opt => opt.MapFrom(src => src.Place))
                .ForMember(a => a.AccountNumber, ac => ac.MapFrom(acc => acc.AccountNumber))
                .ForMember(s => s.Signature, si => si.MapFrom(sig => sig.Signature));
              
        
        }
    }
}
// mapowanie sluży do pobierania danych wysylanych przez użytkownika do bazy, niekoniecznie wszystkie
// automaper automatucznie zmapuje te wlasciwosci które sa takie same dla klasy bazeowej czyli invoice i klacy invoice dto
// wlasciwosci Place, AccountNumber i Signature  sa zmapowane Testowo zeby pamietac jak to sie robi.