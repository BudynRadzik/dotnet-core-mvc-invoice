using Invoice.Application.Invoice.Commands.CreateInvoice;
using Invoice.Application.Invoice.Queries.GetAllInvoices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.MVC.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IMediator _mediator;

        public InvoiceController(IMediator mediator) 
        {
            _mediator = mediator;
        }
        public  async Task<IActionResult> Index()
        {
            var invoices = await _mediator.Send(new GetAllInvoicesQuery());
            return View(invoices);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> Create(CreateInvoiceCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index)); 
        }

    }
}
