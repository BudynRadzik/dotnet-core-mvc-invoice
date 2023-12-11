using Invoice.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.MVC.Controllers
{
    public class InvoiceController : Controller
    { 
        private readonly IInvoiceService _invoiceService;
        public InvoiceController(IInvoiceService invoiceService) 
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public async Task <IActionResult> Create(Domain.Entities.Invoice invoice)
        {
            await _invoiceService.Create(invoice);
            return RedirectToAction(nameof(Create)); // tutaj kontynuacja jak zrobie widok
        }

    }
}
