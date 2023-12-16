using Invoice.Application.Invoice;
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
        public  async Task<IActionResult> Index()
        {
            var invoices = await _invoiceService.GetAll();
            return View(invoices);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> Create(InvoiceDto invoice)
        {
            await _invoiceService.Create(invoice);
            return RedirectToAction(nameof(Index)); 
        }

    }
}
