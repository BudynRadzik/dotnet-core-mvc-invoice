﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Application.Invoice.Commands.CreateInvoice
{
    public class CreateInvoiceCommand :InvoiceDto, IRequest
    {

    }
}
