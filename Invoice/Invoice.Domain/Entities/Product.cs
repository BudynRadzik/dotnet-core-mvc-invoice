using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Domain.Entities
{
    public class Product
    {
        public required int Id { get; set; }
        public string Name { get; set; } = default!;
        public double Tax { get; set; } = default!;
        public double UnitPrice { get; set; } = default!;
        public double Quantity { get; set; } = default!;
        public double NetPrice { get; set; } = default!;
        public double TaxValue { get; set; } = default!;
        public double GrossPrice { get; set; } = default!;


    }
}
